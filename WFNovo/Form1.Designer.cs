namespace WFNovo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblNome = new Label();
            btnCliqueAqui = new Button();
            lblNome1 = new Label();
            lblPassword = new Label();
            Nome = new TextBox();
            Senha = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            LblNome.Location = new Point(21, 20);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(44, 15);
            LblNome.TabIndex = 0;
            LblNome.Text = "Nome:";
            LblNome.Click += label1_Click;
            // 
            // btnCliqueAqui
            // 
            btnCliqueAqui.Location = new Point(21, 54);
            btnCliqueAqui.Name = "btnCliqueAqui";
            btnCliqueAqui.Size = new Size(90, 32);
            btnCliqueAqui.TabIndex = 1;
            btnCliqueAqui.Text = "Clique aqui!";
            btnCliqueAqui.UseVisualStyleBackColor = true;
            btnCliqueAqui.Click += btnCliqueAqui_Click;
            // 
            // lblNome1
            // 
            lblNome1.AutoSize = true;
            lblNome1.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNome1.Location = new Point(21, 135);
            lblNome1.Name = "lblNome1";
            lblNome1.Size = new Size(47, 15);
            lblNome1.TabIndex = 2;
            lblNome1.Text = "Nome:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(21, 175);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // Nome
            // 
            Nome.Location = new Point(109, 135);
            Nome.Name = "Nome";
            Nome.Size = new Size(100, 23);
            Nome.TabIndex = 3;
            // 
            // Senha
            // 
            Senha.Location = new Point(109, 172);
            Senha.Name = "Senha";
            Senha.Size = new Size(100, 23);
            Senha.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderColor = Color.Red;
            btnLogin.FlatAppearance.BorderSize = 3;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Red;
            btnLogin.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(122, 226);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 429);
            Controls.Add(Nome);
            Controls.Add(btnLogin);
            Controls.Add(Senha);
            Controls.Add(lblPassword);
            Controls.Add(lblNome1);
            Controls.Add(btnCliqueAqui);
            Controls.Add(LblNome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "  ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNome;
        private Button btnCliqueAqui;
        private Label lblNome1;
        private Label lblPassword;
        private TextBox Nome;
        private TextBox Senha;
        private Button btnLogin;
    }
}
