using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeClientes
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            AtualizarComboBoxPaises();
            CriarControlesEstadosCivis();
            DesabilitarCampos();
        }

        private void Informar(string mensagem)
        {
            MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool Confirmar(string pergunta)
        {
            return MessageBox.Show(pergunta, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void AtualizarComboBoxPaises()
        {
            cbxNascionalidade.DataSource = Pais.GetPais;
            cbxNascionalidade.DisplayMember = "";
            cbxNascionalidade.DisplayMember = "Nome";
            cbxNascionalidade.ValueMember = "Sigla";
            cbxNascionalidade.SelectedIndex = -1;
        }

        private void AtualizarComboBoxClientes()
        {
            cbxCliente.DataSource = Cliente.ListClientes;
            cbxCliente.DisplayMember = "";
            cbxCliente.DisplayMember = "Nome";
            cbxCliente.ValueMember = "Codigo";
        }

        private void CorrigirTabStop(object sender, EventArgs e)
        {
            ((RadioButton)sender).TabStop = true;
        }

        private void CriarControlesEstadosCivis()
        {
            int iRB = 0;
            var estadoCivis = Enum.GetValues(typeof(EnumEstadoCivil));
            foreach (var item in estadoCivis)
            {
                RadioButton rb = new RadioButton()
                {
                    Text = item.ToString(),
                    Location = new Point(10, (iRB + 1) * 27),
                    Width = 85,
                    TabStop = true,
                    TabIndex = iRB,
                    Tag = item
                };
                rb.TabStopChanged += new EventHandler(CorrigirTabStop);
                gbxEstadoCivil.Controls.Add(rb);
                iRB++;
            }

        }
        private EnumEstadoCivil? LerEstadocivil()
        {
            foreach (var control in gbxEstadoCivil.Controls)
            {
                RadioButton rb = control as RadioButton;
                if (rb.Checked)
                {
                    return (EnumEstadoCivil)rb.Tag;
                }
            }
            return null;
        }
        private void MarcarEstoCivil(EnumEstadoCivil estadoCivil)
        {
            foreach (var control in gbxEstadoCivil.Controls)
            {
                RadioButton rb = control as RadioButton;
                if ((EnumEstadoCivil)rb.Tag == estadoCivil)
                {
                    rb.Checked = true;
                    return;
                }
            }
        }
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            mtbCpf.Clear();
            dtpDataNascimento.Value = DateTime.Now.Date;
            nudRendaMensal.Value = 0;
            foreach (var control in gbxEstadoCivil.Controls)
            {
                (control as RadioButton).Checked = false;
            }
            cbxNascionalidade.SelectedIndex = -1;
            mtbPlacaVeiculo.Clear();
            chkTemFilhos.CheckState = CheckState.Indeterminate;
        }

        private void PreencherCamposComCliente(Cliente cliente)
        {
            txtCodigo.Text = cliente.Codigo.ToString();
            txtNome.Text = cliente.Nome;
            mtbCpf.Text = cliente.Cpf.ToString();
            dtpDataNascimento.Value = cliente.DataNascimento;
            nudRendaMensal.Value = cliente.RendaMensal;
            MarcarEstoCivil(cliente.EstadoCivil);
            cbxNascionalidade.SelectedValue = cliente.Nacionalidade;
            mtbPlacaVeiculo.Text = cliente.PlacaVeiculo;
            chkTemFilhos.Checked = cliente.TemFilhos;
        }
        private void PreencherClienteComCampos(Cliente cliente)
        {
            cliente.Nome = txtNome.Text;
            cliente.Cpf = mtbCpf.Text;
            cliente.DataNascimento = dtpDataNascimento.Value.Date;
            cliente.RendaMensal = nudRendaMensal.Value;
            cliente.EstadoCivil = LerEstadocivil().Value;
            cliente.TemFilhos = chkTemFilhos.Checked;
            cliente.Nacionalidade = cbxNascionalidade.SelectedValue.ToString();
            cliente.PlacaVeiculo = mtbPlacaVeiculo.Text;
        }
        private bool PreencheuTodosOsDados()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text)) return false;
            if (string.IsNullOrWhiteSpace(mtbCpf.Text)) return false;
            if (dtpDataNascimento.Value.Date == DateTime.Now.Date) return false;
            if (nudRendaMensal.Value == 0) return false;
            if (LerEstadocivil() == null) return false;
            if (cbxNascionalidade.SelectedIndex < 0) return false;
            if (string.IsNullOrWhiteSpace(mtbPlacaVeiculo.Text)) return false;
            if (chkTemFilhos.CheckState == CheckState.Indeterminate) return false;

            return true;
        }

        private bool PossuiValoresNaoSalvos()
        {
            if (cbxCliente.SelectedIndex < 0)
            {
                if (!string.IsNullOrWhiteSpace(txtNome.Text)) return true;
                if (!string.IsNullOrWhiteSpace(mtbCpf.Text)) return true;
                if (dtpDataNascimento.Value.Date != DateTime.Now.Date) return true;
                if (nudRendaMensal.Value > 0) return true;
                if (LerEstadocivil() != null) return true;
                if (cbxNascionalidade.SelectedIndex >= 0) return true;
                if (!string.IsNullOrWhiteSpace(mtbPlacaVeiculo.Text)) return true;
                if (chkTemFilhos.CheckState != CheckState.Indeterminate) return true;
            }
            else
            {
                Cliente cliente = cbxCliente.SelectedItem as Cliente;
                if (txtNome.Text.Trim() != cliente.Nome) return true;
                if (mtbCpf.Text != cliente.Cpf.ToString()) return true;
                if (dtpDataNascimento.Value.Date != cliente.DataNascimento) return true;
                if (nudRendaMensal.Value != cliente.RendaMensal) return true;
                if (LerEstadocivil() != cliente.EstadoCivil) return true;
                if (cbxNascionalidade.SelectedValue.ToString() != cliente.Nacionalidade) return true;
                if (mtbPlacaVeiculo.Text != cliente.PlacaVeiculo) return true;
                if (chkTemFilhos.Checked != cliente.TemFilhos) return true;
            }
            return false;
        }

        private void AlterarEstadoDosCampos(bool estado)
        {
            txtNome.Enabled = estado;
            mtbCpf.Enabled = estado;
            dtpDataNascimento.Enabled = estado;
            nudRendaMensal.Enabled = estado;
            gbxEstadoCivil.Enabled = estado;
            cbxNascionalidade.Enabled = estado;
            mtbPlacaVeiculo.Enabled = estado;
            chkTemFilhos.Enabled = estado;
            btnSalvar.Enabled = estado;
            btnCancelar.Enabled = estado;

        }

        private void AlteracaoNaoConfirmada()
        {
            cbxCliente.SelectedIndex = -1;
            LimparCampos();
            cbxCliente.Select();
            DesabilitarCampos();
        }

        private void HabilitarCampo()
        {
            AlterarEstadoDosCampos(true);
        }
        private void DesabilitarCampos()
        {
            AlterarEstadoDosCampos(false);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cbxCliente.SelectedIndex = -1;
            LimparCampos();
            HabilitarCampo();
            txtNome.Select();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (PreencheuTodosOsDados())
            {
                Cliente cliente = cbxCliente.SelectedIndex < 0 ? new Cliente() : cbxCliente.SelectedItem as Cliente;
                PreencherClienteComCampos(cliente);
                DesabilitarCampos();

                if (cbxCliente.SelectedIndex < 0)
                {
                    cliente = Cliente.Insert(cliente);
                    AtualizarComboBoxClientes();
                    Informar("Cliente cadastrado com sucesso!.");
                }
                else
                {
                    AtualizarComboBoxClientes();
                    Informar("Cliente alterado com sucesso!");
                }
            }
            else
            {
                Informar("Só é possivel salvar se todos os campos forem preenchidos.");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (PossuiValoresNaoSalvos())
            {
                if (Confirmar("Há alterações não salvas.Deseja realmente cancelar?"))
                {
                    AlteracaoNaoConfirmada();
                }
            }
            else
            {
                AlteracaoNaoConfirmada();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PossuiValoresNaoSalvos())
            {
                e.Cancel = !Confirmar("Há alterações não salvas. Deseja realmente sair?");
            }
            else
            {
                e.Cancel = !Confirmar("Deseja realmente sair?");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitarCampo();
            txtNome.Select();
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxCliente.SelectedIndex < 0)
            {
                btnAlterar.Enabled = false;
            }
            else
            {
                PreencherCamposComCliente(cbxCliente.SelectedItem as Cliente);
                btnAlterar.Enabled = true;
            }
        }
    }
}
