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
    public partial class FrmCardápio : Form
    {
        CardapioItem? cardapioSelecionado;
        public FrmCardápio()
        {
            InitializeComponent();
        }

        private void FrmCardápio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
        {
            //conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                // concultar na tabela cardapio item * FROM CARDAPIO
                var cardapios = bd.CardapioItems.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    cardapios = cardapios.Where(c => c.Titulo.Contains(txtPesquisa.Text) ||
                                                    c.Descricao.Contains(txtPesquisa.Text));
                }
                //popular o grid com a tabela consultar
                dataGridView1.DataSource = cardapios.ToList();
            }

        }




        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
            BuscarCardapio();
        }




        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
            {
                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.CardapioItems.Remove(cardapioSelecionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Cardápio excluido com sucesso)", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarCardapio();
                cardapioSelecionado = null;
            }
            else
            {
                MessageBox.Show("Selecione um cardapio para excluir", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFecharCardapiocs(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            //chamar o metodo buscar cardapio
            BuscarCardapio();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //click do editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
            {
                // abrir o formulário de edição
                var frmCardapioEdit = new FrmCardapioCad(cardapioSelecionado);
                frmCardapioEdit.ShowDialog();
                BuscarCardapio();
                cardapioSelecionado = null;
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //pegar o cardapio selecionado
                cardapioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as CardapioItem;
                btnEditar.Enabled = true;

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
