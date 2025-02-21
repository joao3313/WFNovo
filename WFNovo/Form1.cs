namespace WFNovo
{
    public partial class Form1 : Form
    {
        public Form1()
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
            if (LblNome.Text.Contains(" Botão Clicado"))
            {
                LblNome.Text = " Clicou Denovo";

            }
            else
            {
                LblNome.Text = " Botão Clicado";

            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
