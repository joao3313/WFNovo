namespace WFNovo
{
    partial class FrmCadastro
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
            lblPreencherCampos = new Label();
            cbxEstado = new ComboBox();
            Lblnome = new Label();
            lblEndereco = new Label();
            lblBairro = new Label();
            lblEstado = new Label();
            lblTelefone = new Label();
            lblCelular = new Label();
            lblEmail = new Label();
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtBairro = new TextBox();
            txtTelefone = new TextBox();
            txtCelular = new TextBox();
            txtEmail = new TextBox();
            btnGravar = new Button();
            btnNovo = new Button();
            btnVer = new Button();
            SuspendLayout();
            // 
            // lblPreencherCampos
            // 
            lblPreencherCampos.AutoSize = true;
            lblPreencherCampos.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreencherCampos.Location = new Point(82, 9);
            lblPreencherCampos.Name = "lblPreencherCampos";
            lblPreencherCampos.Size = new Size(322, 19);
            lblPreencherCampos.TabIndex = 0;
            lblPreencherCampos.Text = "Preencha os campos e clique em Gravar Dados";
            lblPreencherCampos.Click += label1_Click;
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "AC", "", "AL", "", "AM", "", "BA", "", "CE", "", "DF", "", "ES", "", "GO", "", "MA", "", "MT", "", "MS", "", "MG", "", "PA", "", "PB", "", "PR", "", "PE", "", "PI", "", "RJ", "", "RN", "", "RS", "", "RO", "", "RR", "", "SC", "", "SP", "", "SE", "", "TO", "", "" });
            cbxEstado.Location = new Point(173, 201);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(121, 23);
            cbxEstado.TabIndex = 1;
            // 
            // Lblnome
            // 
            Lblnome.AutoSize = true;
            Lblnome.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lblnome.Location = new Point(56, 76);
            Lblnome.Name = "Lblnome";
            Lblnome.Size = new Size(45, 15);
            Lblnome.TabIndex = 0;
            Lblnome.Text = "Nome :";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(56, 116);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(64, 15);
            lblEndereco.TabIndex = 0;
            lblEndereco.Text = "Endereço :";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBairro.Location = new Point(56, 159);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(51, 15);
            lblBairro.TabIndex = 0;
            lblBairro.Text = "Bairro :";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(54, 201);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(49, 15);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Estado :";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(54, 244);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(60, 15);
            lblTelefone.TabIndex = 0;
            lblTelefone.Text = "Telefone :";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCelular.Location = new Point(54, 283);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(56, 15);
            lblCelular.TabIndex = 0;
            lblCelular.Text = "Celular :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(56, 328);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(45, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email :";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(173, 73);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(188, 23);
            txtNome.TabIndex = 2;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(173, 113);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(188, 23);
            txtEndereco.TabIndex = 2;
            txtEndereco.TextChanged += textBox2_TextChanged;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(173, 159);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(188, 23);
            txtBairro.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(173, 241);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 3;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(173, 275);
            txtCelular.Multiline = true;
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(100, 23);
            txtCelular.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(173, 320);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(188, 23);
            txtEmail.TabIndex = 3;
            // 
            // btnGravar
            // 
            btnGravar.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(56, 382);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(108, 23);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar Cadastro";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(198, 382);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(96, 23);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "Novo Cadastro";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            btnVer.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVer.Location = new Point(335, 382);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(85, 23);
            btnVer.TabIndex = 4;
            btnVer.Text = "Ver Cadastro";
            btnVer.UseVisualStyleBackColor = true;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 427);
            Controls.Add(btnVer);
            Controls.Add(btnNovo);
            Controls.Add(btnGravar);
            Controls.Add(txtEmail);
            Controls.Add(txtCelular);
            Controls.Add(txtTelefone);
            Controls.Add(txtBairro);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Controls.Add(cbxEstado);
            Controls.Add(lblEmail);
            Controls.Add(lblCelular);
            Controls.Add(lblTelefone);
            Controls.Add(lblEstado);
            Controls.Add(lblBairro);
            Controls.Add(lblEndereco);
            Controls.Add(Lblnome);
            Controls.Add(lblPreencherCampos);
            Name = "FrmCadastro";
            Text = "Cadastro de Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPreencherCampos;
        private ComboBox cbxEstado;
        private Label Lblnome;
        private Label lblEndereco;
        private Label lblBairro;
        private Label lblEstado;
        private Label lblTelefone;
        private Label lblCelular;
        private Label lblEmail;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtBairro;
        private TextBox txtTelefone;
        private TextBox txtCelular;
        private TextBox txtEmail;
        private Button btnGravar;
        private Button btnNovo;
        private Button btnVer;
    }
}