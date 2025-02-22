namespace WFNovo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCliqueAqui_Click(object sender, EventArgs e)
        {
            if (LblNome.Text.Contains(" Bot�o Clicado"))
            {
                LblNome.Text = " Clicou Denovo";

            }
            else
            {
                LblNome.Text = " Bot�o Clicado";

            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtNome.Text.Trim();
            string password = txtSenha.Text.Trim();

            if (username != string.Empty && password != string.Empty)
            {
                FrmCadastro frmCadastro = new FrmCadastro();
                frmCadastro.ShowDialog();

            }
            else
            {

                MessageBox.Show(" Os campos n�o podem esta vazios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
