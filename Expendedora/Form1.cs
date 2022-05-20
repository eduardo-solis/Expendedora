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

            venta.Precio = Convert.ToDouble(lbPrecio.Text);
            venta.Saldo = Convert.ToDouble(lbSaldo.Text);
            venta.Cambio = Convert.ToDouble(lbCambio.Text);
            venta.Cantidad_coca = Convert.ToInt32(lbCoca.Text);
            venta.Cantidad_fresca = Convert.ToInt32(lbFresca.Text);
            venta.Cantidad_fanta = Convert.ToInt32(lbFanta.Text);
            venta.Cantidad_sprite = Convert.ToInt32(lbSprite.Text);
            venta.Cantidad_manzanita = Convert.ToInt32(lbManzanita.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                double moneda = Convert.ToDouble(txtMoneda.Text);

                if (moneda == 0.5 || moneda == 1 || moneda == 2 || moneda == 5 || moneda == 10)
                {
                    venta.modificar_saldo(moneda);

                    lbSaldo.Text = Convert.ToString(venta.Saldo);

                    if (venta.Saldo >= venta.Precio)
                    {
                        groupBox1.Enabled = true;
                        btnDespachar.Enabled = true;
                        btnInsertar.Enabled = false;

                        if(lbCoca.Text == "0")
                        {
                            rbtnCoca.Enabled = false;
                        }
                        if (lbFanta.Text == "0")
                        {
                            rbtnFanta.Enabled = false;
                        }
                        if (lbFresca.Text == "0")
                        {
                            rbtnFresca.Enabled = false;
                        }
                        if (lbSprite.Text == "0")
                        {
                            rbtnSprite.Enabled = false;
                        }
                        if (lbManzanita.Text == "0")
                        {
                            rbtnManzanita.Enabled = false;
                        }


                        venta.Cambio = venta.Saldo - venta.Precio;
                        lbCambio.Text = Convert.ToString(venta.Cambio);
                    }

                }
                else
                {
                    MessageBox.Show("La moneda ingresada debe ser de 0.50, 1, 2, 5 o 10 pesos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtMoneda.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nDebe ser un numero decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void surtirRefresco(int refresco)
        {
            try
            {
                int cantidad_a_surtir = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad a surtir", "Surtir refresco", "1"));

                switch (refresco)
                {
                    case 1:
                        venta.surtir(cantidad_a_surtir, 1);
                        lbCoca.Text = Convert.ToString(venta.Cantidad_coca);
                        break;

                    case 2:
                        venta.surtir(cantidad_a_surtir, 2);
                        lbFresca.Text = Convert.ToString(venta.Cantidad_fresca);
                        break;

                    case 3:
                        
                        venta.surtir(cantidad_a_surtir, 3);
                        lbFanta.Text = Convert.ToString(venta.Cantidad_fanta);
                        break;

                    case 4:
                        
                        venta.surtir(cantidad_a_surtir, 4);
                        lbSprite.Text = Convert.ToString(venta.Cantidad_sprite);
                        break;

                    case 5:
                        
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

        private void cambiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                
                String nuevo_precio = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el precio de los refrescos", "Precio del refresco", "4,5");
                if ( nuevo_precio.Contains(",5") || !nuevo_precio.Contains(",") )
                {
                    
                    venta.Precio = Convert.ToDouble(nuevo_precio);
                    lbPrecio.Text = Convert.ToString(venta.Precio);
                }
                else
                {
                    MessageBox.Show("El precio debe terminar en 0.5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nDebe ser un numero decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            if (rbtnCoca.Checked) 
            {
                venta.despachar(1);
                lbCoca.Text = Convert.ToString(venta.Cantidad_coca);
            }
            if (rbtnFresca.Checked) 
            { 
                venta.despachar(2);
                lbFresca.Text = Convert.ToString(venta.Cantidad_fresca);
            }
            if (rbtnFanta.Checked) 
            { 
                venta.despachar(3);
                lbFanta.Text = Convert.ToString(venta.Cantidad_fanta);
            }
            if (rbtnSprite.Checked) 
            { 
                venta.despachar(4);
                lbFanta.Text = Convert.ToString(venta.Cantidad_sprite);
            }
            if (rbtnManzanita.Checked) 
            { 
                venta.despachar(5);
                lbManzanita.Text = Convert.ToString(venta.Cantidad_manzanita);
            }

            lbSaldo.Text = Convert.ToString(venta.Saldo);
            lbCambio.Text = Convert.ToString(venta.Cambio);

            MessageBox.Show("Gracias por su compra.", "Gracias", MessageBoxButtons.OK, MessageBoxIcon.Information);

            groupBox1.Enabled = false;
            btnDespachar.Enabled = false;
            btnInsertar.Enabled = true;
            pbRefresco.Image = Expendedora.Properties.Resources.negro;

            rbtnCoca.Checked = false;
            rbtnFresca.Checked = false;
            rbtnFanta.Checked = false;
            rbtnSprite.Checked = false;
            rbtnManzanita.Checked = false;



        }

        private void rbtnCoca_CheckedChanged(object sender, EventArgs e)
        {
            pbRefresco.Image = Expendedora.Properties.Resources.cocacola;
        }

        private void rbtnFresca_CheckedChanged(object sender, EventArgs e)
        {
            pbRefresco.Image = Expendedora.Properties.Resources.fresca;
        }

        private void rbtnFanta_CheckedChanged(object sender, EventArgs e)
        {
            pbRefresco.Image = Expendedora.Properties.Resources.fanta;
        }

        private void rbtnSprite_CheckedChanged(object sender, EventArgs e)
        {
            pbRefresco.Image = Expendedora.Properties.Resources.sprite;
        }

        private void rbtnManzanita_CheckedChanged(object sender, EventArgs e)
        {
            pbRefresco.Image = Expendedora.Properties.Resources.manzanita;
        }
    }
}
