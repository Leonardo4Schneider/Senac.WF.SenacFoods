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
                    cardapios = cardapios.Where(c=> c.Titulo.Contains(txtPesquisa.Text) ||
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




        private void btnExcluirCardapio_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
