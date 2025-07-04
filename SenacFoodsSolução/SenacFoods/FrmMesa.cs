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
        public FrmMesa()
        {
            InitializeComponent();
        }

        private void FrmCardápio_Load(object sender, EventArgs e)
        {
            BuscarMesa();
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

        private void btnExcluirCardapio_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarMesa();
        }
    }
}

        

       

        

        