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
    public partial class FrmUsuario : Form
    {
        Usuario? usuarioSelecionado;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void BuscarUsuario()
        {  //conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                // concultar na tabela cardapio item * FROM CARDAPIO
                var usuarios = bd.Usuarios.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    usuarios = usuarios.Where(c => c.Nome.Contains(txtPesquisa.Text));

                }
                //popular o grid com a tabela consultar
                dataGridView1.DataSource = usuarios.ToList();
            }
        }



        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuario();
        }



        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmUsuariosCad().ShowDialog();
            BuscarUsuario();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void btnExcluirMesa_Click(object sender, EventArgs e)
        {
            if (usuarioSelecionado != null)
            {
                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.Usuarios.Remove(usuarioSelecionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Cardápio excluido com sucesso)", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarUsuario();
                usuarioSelecionado = null;
            }
            else
            {
                MessageBox.Show("Selecione um cardapio para excluir", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFecharUsuariocs_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (usuarioSelecionado != null)
            {
                // abrir o formulário de edição
                var frmusuariosEdit = new FrmUsuariosCad(usuarioSelecionado);
                frmusuariosEdit.ShowDialog();
                BuscarUsuario();
                usuarioSelecionado = null;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                //pegar o cardapio selecionado
                usuarioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
                btnEditar.Enabled = true;

            }
        }
    }
}
