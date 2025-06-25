namespace SenacFoods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        { //true, salse
            bool loginvalido = ValidarLogin(TxtLogin.Text, TxtSenha.Text);
            // SE true
            if (loginvalido)
            {
                //oculta a tela de Login
                this.Hide();
                //criar uma instancia do FrmPrincipal
                var FrmPrincipal = new FrmPrincipal(TxtLogin.Text, TxtSenha.Text);
                // exibe a tela principal
                FrmPrincipal.Show();
            }
        }


        private bool ValidarLogin(string nome, string senha)
        {
            bool usuarioValido = false;
            using (var banco = new ComandaDBContext())
            {

                var usuario = banco
                    .Usuarios
                    .FirstOrDefault(u => u.Email.ToLower() == nome.ToLower() && u.Senha == senha);
                if (usuario is not null)
                    usuarioValido = true;

            }
            // se nome é igual a admin e senha é igual a 123
            if (usuarioValido)
            { //Returna verdadeiro
                return true;
            }
            else
            {  //Exibe mensagem de erro
                MessageBox.Show("Login ou senha inválidos");
            } //Retorna false
            return false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
