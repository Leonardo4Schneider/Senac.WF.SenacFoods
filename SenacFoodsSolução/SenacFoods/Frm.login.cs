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
        {   //SE nome é igual a admin E senha é igual a 123
            if (nome == "admin" && senha == "123")
            {//RETURNA verdadeiro
                return true;
            }
            else
            { //EXIBE uma mensagem de erro
                MessageBox.Show("Login ou Senha inválidos");
            }// Retorna false
            
            return false;
        }
    }
}
