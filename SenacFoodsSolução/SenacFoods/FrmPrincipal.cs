using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(string nome, string senha)
        {
            InitializeComponent();
            //exibe o nome do usuaio na tela principal
            lblMensagem.Text = "Bem Vindo " + nome;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmUsuario().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmPedido_Cozinha().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmComanda().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCardápio().Show();
        }
    }
}
