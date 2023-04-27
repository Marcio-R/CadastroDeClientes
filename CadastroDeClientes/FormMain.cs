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
    }
}
