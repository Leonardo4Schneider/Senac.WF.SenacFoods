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
                // concultar na tabela cardapio item
                var cardapios = bd.CardapioItems.ToList();
                //popular o grid com a tabela consultar
                dataGridView1.DataSource = cardapios;
            }
            
        }
    }
}
