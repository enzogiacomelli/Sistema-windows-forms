namespace Sistema.Telas
{
    partial class PessoasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelNome = new Label();
            labelSobrenome = new Label();
            textBoxNome = new TextBox();
            textBoxSobrenome = new TextBox();
            labelCpf = new Label();
            labelTelefone = new Label();
            groupBoxUsuario = new GroupBox();
            buttonLimpar = new Button();
            buttonCadastrar = new Button();
            maskedTextBoxTelefone = new MaskedTextBox();
            maskedTextBoxCpf = new MaskedTextBox();
            textBoxSenha = new TextBox();
            labelSenha = new Label();
            notifyIcon1 = new NotifyIcon(components);
            groupBoxEndereco = new GroupBox();
            buttonLimparEndereco = new Button();
            textBoxComplemento = new TextBox();
            textBoxNumero = new TextBox();
            textBoxRua = new TextBox();
            labelNumero = new Label();
            labelApartamento = new Label();
            labelRua = new Label();
            textBoxApartamento = new TextBox();
            labelComplemento = new Label();
            textBoxBairro = new TextBox();
            labelBairro = new Label();
            textBoxCidade = new TextBox();
            labelCidade = new Label();
            textBoxUf = new TextBox();
            labelUf = new Label();
            textBoxCep = new TextBox();
            labelCep = new Label();
            groupBoxUsuario.SuspendLayout();
            groupBoxEndereco.SuspendLayout();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(6, 19);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // labelSobrenome
            // 
            labelSobrenome.AutoSize = true;
            labelSobrenome.Location = new Point(166, 19);
            labelSobrenome.Name = "labelSobrenome";
            labelSobrenome.Size = new Size(68, 15);
            labelSobrenome.TabIndex = 1;
            labelSobrenome.Text = "Sobrenome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(6, 37);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(154, 23);
            textBoxNome.TabIndex = 2;
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.Location = new Point(166, 37);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(154, 23);
            textBoxSobrenome.TabIndex = 3;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(84, 63);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(28, 15);
            labelCpf.TabIndex = 4;
            labelCpf.Text = "CPF";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(6, 63);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(51, 15);
            labelTelefone.TabIndex = 6;
            labelTelefone.Text = "Telefone";
            // 
            // groupBoxUsuario
            // 
            groupBoxUsuario.Controls.Add(buttonLimpar);
            groupBoxUsuario.Controls.Add(buttonCadastrar);
            groupBoxUsuario.Controls.Add(maskedTextBoxTelefone);
            groupBoxUsuario.Controls.Add(maskedTextBoxCpf);
            groupBoxUsuario.Controls.Add(textBoxSenha);
            groupBoxUsuario.Controls.Add(labelSenha);
            groupBoxUsuario.Controls.Add(labelNome);
            groupBoxUsuario.Controls.Add(labelSobrenome);
            groupBoxUsuario.Controls.Add(labelTelefone);
            groupBoxUsuario.Controls.Add(textBoxNome);
            groupBoxUsuario.Controls.Add(textBoxSobrenome);
            groupBoxUsuario.Controls.Add(labelCpf);
            groupBoxUsuario.Location = new Point(12, 12);
            groupBoxUsuario.Name = "groupBoxUsuario";
            groupBoxUsuario.Size = new Size(327, 142);
            groupBoxUsuario.TabIndex = 8;
            groupBoxUsuario.TabStop = false;
            groupBoxUsuario.Text = "Usuário";
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(166, 110);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(75, 23);
            buttonLimpar.TabIndex = 13;
            buttonLimpar.Text = "Cancelar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(245, 110);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 12;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(6, 81);
            maskedTextBoxTelefone.Mask = "(00)000000000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(72, 23);
            maskedTextBoxTelefone.TabIndex = 11;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(84, 81);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(76, 23);
            maskedTextBoxCpf.TabIndex = 10;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(166, 81);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(154, 23);
            textBoxSenha.TabIndex = 9;
            textBoxSenha.UseSystemPasswordChar = true;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(166, 63);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(39, 15);
            labelSenha.TabIndex = 8;
            labelSenha.Text = "Senha";
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Text = "A senha deve conter entre 8 e 20 caracteres.\r\n";
            notifyIcon1.Visible = true;
            // 
            // groupBoxEndereco
            // 
            groupBoxEndereco.Controls.Add(buttonLimparEndereco);
            groupBoxEndereco.Controls.Add(textBoxComplemento);
            groupBoxEndereco.Controls.Add(textBoxNumero);
            groupBoxEndereco.Controls.Add(textBoxRua);
            groupBoxEndereco.Controls.Add(labelNumero);
            groupBoxEndereco.Controls.Add(labelApartamento);
            groupBoxEndereco.Controls.Add(labelRua);
            groupBoxEndereco.Controls.Add(textBoxApartamento);
            groupBoxEndereco.Controls.Add(labelComplemento);
            groupBoxEndereco.Controls.Add(textBoxBairro);
            groupBoxEndereco.Controls.Add(labelBairro);
            groupBoxEndereco.Controls.Add(textBoxCidade);
            groupBoxEndereco.Controls.Add(labelCidade);
            groupBoxEndereco.Controls.Add(textBoxUf);
            groupBoxEndereco.Controls.Add(labelUf);
            groupBoxEndereco.Controls.Add(textBoxCep);
            groupBoxEndereco.Controls.Add(labelCep);
            groupBoxEndereco.Location = new Point(345, 12);
            groupBoxEndereco.Name = "groupBoxEndereco";
            groupBoxEndereco.Size = new Size(327, 212);
            groupBoxEndereco.TabIndex = 9;
            groupBoxEndereco.TabStop = false;
            groupBoxEndereco.Text = "Endereço";
            // 
            // buttonLimparEndereco
            // 
            buttonLimparEndereco.Location = new Point(241, 171);
            buttonLimparEndereco.Name = "buttonLimparEndereco";
            buttonLimparEndereco.Size = new Size(75, 23);
            buttonLimparEndereco.TabIndex = 18;
            buttonLimparEndereco.Text = "Cancelar";
            buttonLimparEndereco.UseVisualStyleBackColor = true;
            buttonLimparEndereco.Click += buttonLimparEndereco_Click;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(7, 172);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(228, 23);
            textBoxComplemento.TabIndex = 17;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(7, 125);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(75, 23);
            textBoxNumero.TabIndex = 9;
            // 
            // textBoxRua
            // 
            textBoxRua.Location = new Point(173, 81);
            textBoxRua.Name = "textBoxRua";
            textBoxRua.Size = new Size(143, 23);
            textBoxRua.TabIndex = 15;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(7, 107);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(51, 15);
            labelNumero.TabIndex = 8;
            labelNumero.Text = "Numero";
            // 
            // labelApartamento
            // 
            labelApartamento.AutoSize = true;
            labelApartamento.Location = new Point(86, 107);
            labelApartamento.Name = "labelApartamento";
            labelApartamento.Size = new Size(77, 15);
            labelApartamento.TabIndex = 10;
            labelApartamento.Text = "Apartamento";
            // 
            // labelRua
            // 
            labelRua.AutoSize = true;
            labelRua.Location = new Point(173, 63);
            labelRua.Name = "labelRua";
            labelRua.Size = new Size(27, 15);
            labelRua.TabIndex = 14;
            labelRua.Text = "Rua";
            // 
            // textBoxApartamento
            // 
            textBoxApartamento.Location = new Point(88, 125);
            textBoxApartamento.Name = "textBoxApartamento";
            textBoxApartamento.Size = new Size(75, 23);
            textBoxApartamento.TabIndex = 11;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(7, 154);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(84, 15);
            labelComplemento.TabIndex = 16;
            labelComplemento.Text = "Complemento";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(7, 81);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(160, 23);
            textBoxBairro.TabIndex = 13;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(7, 63);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(38, 15);
            labelBairro.TabIndex = 12;
            labelBairro.Text = "Bairro";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(156, 37);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(160, 23);
            textBoxCidade.TabIndex = 7;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(160, 19);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(44, 15);
            labelCidade.TabIndex = 6;
            labelCidade.Text = "Cidade";
            // 
            // textBoxUf
            // 
            textBoxUf.Location = new Point(112, 37);
            textBoxUf.Name = "textBoxUf";
            textBoxUf.Size = new Size(38, 23);
            textBoxUf.TabIndex = 5;
            // 
            // labelUf
            // 
            labelUf.AutoSize = true;
            labelUf.Location = new Point(112, 19);
            labelUf.Name = "labelUf";
            labelUf.Size = new Size(21, 15);
            labelUf.TabIndex = 4;
            labelUf.Text = "UF";
            // 
            // textBoxCep
            // 
            textBoxCep.Location = new Point(6, 37);
            textBoxCep.Name = "textBoxCep";
            textBoxCep.Size = new Size(100, 23);
            textBoxCep.TabIndex = 1;
            textBoxCep.KeyDown += textBoxCep_KeyDown;
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(6, 19);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(28, 15);
            labelCep.TabIndex = 0;
            labelCep.Text = "Cep";
            // 
            // PessoasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 238);
            Controls.Add(groupBoxEndereco);
            Controls.Add(groupBoxUsuario);
            MaximizeBox = false;
            Name = "PessoasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Usuário";
            TopMost = true;
            groupBoxUsuario.ResumeLayout(false);
            groupBoxUsuario.PerformLayout();
            groupBoxEndereco.ResumeLayout(false);
            groupBoxEndereco.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelNome;
        private Label labelSobrenome;
        private TextBox textBoxNome;
        private TextBox textBoxSobrenome;
        private Label labelCpf;
        private Label labelTelefone;
        private GroupBox groupBoxUsuario;
        private TextBox textBoxSenha;
        private Label labelSenha;
        public NotifyIcon notifyIcon1;
        private MaskedTextBox maskedTextBoxCpf;
        private MaskedTextBox maskedTextBoxTelefone;
        private Button buttonLimpar;
        private Button buttonCadastrar;
        private GroupBox groupBoxEndereco;
        private TextBox textBoxCep;
        private Label labelCep;
        private TextBox textBoxUf;
        private Label labelUf;
        private TextBox textBoxNumero;
        private Label labelNumero;
        private TextBox textBoxCidade;
        private Label labelCidade;
        private TextBox textBoxApartamento;
        private Label labelApartamento;
        private TextBox textBoxComplemento;
        private Label labelComplemento;
        private TextBox textBoxRua;
        private Label labelRua;
        private TextBox textBoxBairro;
        private Label labelBairro;
        private Button buttonLimparEndereco;
    }
}