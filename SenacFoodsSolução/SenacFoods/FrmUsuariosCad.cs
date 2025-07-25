using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatorio Colocar Senha ");
                return;
            }
            if (txtConfirmarSenha.Text == "")
            {
                MessageBox.Show("Obrigatorio Confirmar Senha");
                return;
            }
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatorio colocar um nome");
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Obrigatorio Colocar um email ");
                return;
            }
            if (txtConfirmarSenha.Text != txtSenha.Text)
            {
                MessageBox.Show("As senhas não são iguais");
                return;
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Obrigatorio colocar um Perfil ");
                return;
            }
            //inserir
            if (_usuario == null)
            {
                InserirUsuario();
            }
            //atualizar
            else
            {
                AtualizarUsuario();
            }
            
        }
        private void AtualizarUsuario()
        {
            using (var banco = new ComandaDBContext())
            {
                //captar os dados da tela
                string Nome = txtNome.Text;
                string Email = txtEmail.Text;
                string Senha = txtSenha.Text;
                string ComboBox1 = comboBox1.Text;
                //atualizar o cardapio
                var usuario = banco.Usuarios.First(x => x.Id == _usuario.Id);
                usuario.Nome = Nome;
                usuario.Email = Email;
                usuario.Senha = Senha;
                usuario.Perfil = ComboBox1;

                //salvar as alteraçoes no banco
                banco.Usuarios.Update(usuario);
                banco.SaveChanges();

            }
            MessageBox.Show("Usuario salvo com sucesso!",
                 "Sucesso",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            this.Close();
        }




        private void InserirUsuario()
        {


            //conectar
            using (var banco = new ComandaDBContext())
            {


                //capturar os dados da tela
                string Nome = txtNome.Text;
                string Email = txtEmail.Text;
                string Senha = txtSenha.Text;
                string ComboBox1 = comboBox1.Text;
                //criar um novo cardapio
                var usuarioNovo = new Usuario()
                {
                    Nome = Nome,
                    Email = Email,
                    Senha = Senha,
                    Perfil = ComboBox1
                };
                //adicionar o cardapio //salvar as alteraçoes no banco
                banco.Usuarios.Add(usuarioNovo);
                banco.SaveChanges();
            }
            MessageBox.Show("Usuario salvo com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuariosCad_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text.Length > 5)
            {

            }
            else
            {
                MessageBox.Show("Senha deve ter no mínimo 6 caracteres!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
    }
}
}
