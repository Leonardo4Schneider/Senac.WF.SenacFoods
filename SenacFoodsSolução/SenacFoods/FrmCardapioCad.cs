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
    public partial class FrmCardapioCad : Form
    {
        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCardapio();
        }

        private void SalvarCardapio()
        {
            //conectar
            using (var banco = new ComandaDBContext())
            {


                //capturar os dados da tela
                string titulo = txtTitulo.Text;
                    string descricao = txtDescricao.Text;
                decimal.TryParse(textPreco.Text, out var preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;
                //criar um novo cardapio
                var cardapio = new CardapioItem()
                {
                    Descricao = descricao,
                    Titulo = titulo,
                    Preco = preco,
                    PossuiPreparo = possuiPreparo
                };
            //adicionar o cardapio //salvar as alteraçoes no banco
             banco.CardapioItems.Add(cardapio);
             banco.SaveChanges();
             }

    }
    }
}
