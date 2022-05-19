using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expendedora
{
    public partial class Form1 : Form
    {

        Venta venta = new Venta();

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }

        private void surtirRefresco(int refresco)
        {
            try
            {
                int cantidad_a_surtir = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad a surtir", "Surtir refresco", "1"));

                switch (refresco)
                {
                    case 1:
                        venta.Cantidad_coca = Convert.ToInt32(lbCoca.Text);
                        venta.surtir(cantidad_a_surtir, 1);
                        lbCoca.Text = Convert.ToString(venta.Cantidad_coca);
                        break;

                    case 2:
                        venta.Cantidad_fresca = Convert.ToInt32(lbFresca.Text);
                        venta.surtir(cantidad_a_surtir, 2);
                        lbFresca.Text = Convert.ToString(venta.Cantidad_fresca);
                        break;

                    case 3:
                        venta.Cantidad_fanta = Convert.ToInt32(lbFanta.Text);
                        venta.surtir(cantidad_a_surtir, 3);
                        lbFanta.Text = Convert.ToString(venta.Cantidad_fanta);
                        break;

                    case 4:
                        venta.Cantidad_sprite = Convert.ToInt32(lbSprite.Text);
                        venta.surtir(cantidad_a_surtir, 4);
                        lbSprite.Text = Convert.ToString(venta.Cantidad_sprite);
                        break;

                    case 5:
                        venta.Cantidad_manzanita = Convert.ToInt32(lbManzanita.Text);
                        venta.surtir(cantidad_a_surtir, 5);
                        lbManzanita.Text = Convert.ToString(venta.Cantidad_manzanita);
                        break;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nDebe ser un numero entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cocaColaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            surtirRefresco(1);
        }

        private void frescaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            surtirRefresco(2);
        }
        private void fantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            surtirRefresco(3);
        }

        private void spriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            surtirRefresco(4);
        }

        private void manzanitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            surtirRefresco(5);
        }
    }
}
