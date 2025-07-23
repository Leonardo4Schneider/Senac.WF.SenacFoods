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
    public partial class FrmUsuariosCad : Form
    {
        private Usuario _usuario;
        public FrmUsuariosCad()
        {
            InitializeComponent();
        }

        public FrmUsuariosCad(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();

            //carregar os dados da tela
            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            //popular os campos de texto e checkbox
            if (_usuario != null)
            {
                txtNome.Text = _usuario.Nome;
                txtEmail.Text = _usuario.Email;
                txtSenha.Text = _usuario.Senha;
                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
