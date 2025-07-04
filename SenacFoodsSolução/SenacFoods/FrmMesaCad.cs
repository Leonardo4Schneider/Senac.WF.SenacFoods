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
    public partial class FrmMesaCad : Form
    {
        public FrmMesaCad()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarMesa();
        }

        private void SalvarMesa()
        {
            //conectar
            using (var banco = new ComandaDBContext())
            {


                //capturar os dados da tela
                int numero = int.Parse(txtNumeroMesa.Text);

                //criar um novo cardapio
                var Mesas = new Mesa()
                {

                    NumeroMesa = numero,

                };
                //adicionar o cardapio //salvar as alteraçoes no banco
                banco.Mesas.Add(Mesas);
                banco.SaveChanges();
            }
            MessageBox.Show("Mesa salvo com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
