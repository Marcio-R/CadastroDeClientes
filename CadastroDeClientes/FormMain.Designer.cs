
namespace CadastroDeClientes
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.nudRendaMensal = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.cbxNascionalidade = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtbPlacaVeiculo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkTemFilhos = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRendaMensal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // cbxCliente
            // 
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(16, 55);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(297, 21);
            this.cbxCliente.TabIndex = 0;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(314, 55);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(36, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(349, 55);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(36, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(16, 135);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(40, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome Completo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(78, 135);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(168, 20);
            this.txtNome.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CPF";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(262, 135);
            this.mtbCpf.Mask = "000.000.000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(123, 20);
            this.mtbCpf.TabIndex = 5;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(16, 197);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(104, 20);
            this.dtpDataNascimento.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data de Nascimento";
            // 
            // nudRendaMensal
            // 
            this.nudRendaMensal.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudRendaMensal.Location = new System.Drawing.Point(136, 197);
            this.nudRendaMensal.Name = "nudRendaMensal";
            this.nudRendaMensal.Size = new System.Drawing.Size(120, 20);
            this.nudRendaMensal.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Renda Mensal";
            // 
            // gbxEstadoCivil
            // 
            this.gbxEstadoCivil.Location = new System.Drawing.Point(262, 181);
            this.gbxEstadoCivil.Name = "gbxEstadoCivil";
            this.gbxEstadoCivil.Size = new System.Drawing.Size(123, 139);
            this.gbxEstadoCivil.TabIndex = 8;
            this.gbxEstadoCivil.TabStop = false;
            this.gbxEstadoCivil.Text = "Estado Civil";
            // 
            // cbxNascionalidade
            // 
            this.cbxNascionalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNascionalidade.FormattingEnabled = true;
            this.cbxNascionalidade.Location = new System.Drawing.Point(16, 247);
            this.cbxNascionalidade.MaxDropDownItems = 20;
            this.cbxNascionalidade.Name = "cbxNascionalidade";
            this.cbxNascionalidade.Size = new System.Drawing.Size(104, 21);
            this.cbxNascionalidade.Sorted = true;
            this.cbxNascionalidade.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nascionalidade";
            // 
            // mtbPlacaVeiculo
            // 
            this.mtbPlacaVeiculo.Location = new System.Drawing.Point(133, 248);
            this.mtbPlacaVeiculo.Mask = ">LLL|0>L|000";
            this.mtbPlacaVeiculo.Name = "mtbPlacaVeiculo";
            this.mtbPlacaVeiculo.Size = new System.Drawing.Size(123, 20);
            this.mtbPlacaVeiculo.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Placa do Veiculo";
            // 
            // chkTemFilhos
            // 
            this.chkTemFilhos.AutoSize = true;
            this.chkTemFilhos.Checked = true;
            this.chkTemFilhos.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkTemFilhos.Location = new System.Drawing.Point(16, 283);
            this.chkTemFilhos.Name = "chkTemFilhos";
            this.chkTemFilhos.Size = new System.Drawing.Size(74, 17);
            this.chkTemFilhos.TabIndex = 11;
            this.chkTemFilhos.Text = "Tem filhos";
            this.chkTemFilhos.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(6, 327);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(400, 1);
            this.label10.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(5, 97);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(400, 1);
            this.label11.TabIndex = 22;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(310, 346);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(229, 346);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(16, 346);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 382);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkTemFilhos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mtbPlacaVeiculo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxNascionalidade);
            this.Controls.Add(this.gbxEstadoCivil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudRendaMensal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrod de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.nudRendaMensal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudRendaMensal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbxEstadoCivil;
        private System.Windows.Forms.ComboBox cbxNascionalidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtbPlacaVeiculo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkTemFilhos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFechar;
    }
}

