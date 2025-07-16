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
    public partial class FrmMesa : Form
    {
        Mesa? mesaSelecionado;
        public FrmMesa()
        {
            InitializeComponent();
        }



        private void BuscarMesa()
        {
            //conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                // concultar na tabela cardapio item * FROM CARDAPIO
                var mesas = bd.Mesas.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))

                    mesas = mesas.Where(c => c.NumeroMesa == int.Parse(txtPesquisa.Text));
                //popular o grid com a tabela consultar
                dataGridView1.DataSource = mesas.ToList();
            }

        }




        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmMesaCad().ShowDialog();
            BuscarMesa();
        }

        private void btnExcluirMesa_Click(object sender, EventArgs e)
        {
            if (mesaSelecionado != null)
            {
                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.Mesas.Remove(mesaSelecionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Mesa excluido com sucesso)", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarMesa();
                mesaSelecionado = null;
            }
            else
            {
                MessageBox.Show("Selecione um cardapio para excluir", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            {
                if (mesaSelecionado != null)
                {
                    // abrir o formulário de edição
                    var frmCardapioEdit = new FrmMesaCad(mesaSelecionado);
                    frmCardapioEdit.ShowDialog();
                    BuscarMesa();
                    mesaSelecionado = null;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                //pegar a mesa selecionado
                mesaSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Mesa;
                btnEditar.Enabled = true;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMesa_Load(object sender, EventArgs e)
        {
            BuscarMesa();
        }
    }
}

        

       

        

        