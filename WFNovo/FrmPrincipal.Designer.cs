namespace WFNovo
{
    partial class FrmPrincipal
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
            btnlogar = new Button();
            SuspendLayout();
            // 
            // btnlogar
            // 
            btnlogar.Location = new Point(69, 87);
            btnlogar.Name = "btnlogar";
            btnlogar.Size = new Size(116, 71);
            btnlogar.TabIndex = 0;
            btnlogar.Text = "Logar";
            btnlogar.UseVisualStyleBackColor = true;
            btnlogar.Click += btnlogar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 245);
            Controls.Add(btnlogar);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnlogar;
    }
}