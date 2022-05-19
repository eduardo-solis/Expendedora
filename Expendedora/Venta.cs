using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    class Venta
    {

        private int precio;
        
        private int cantidad_coca;
        private int cantidad_fresca;
        private int cantidad_fanta;
        private int cantidad_sprite;
        private int cantidad_manzanita;

        private double saldo;
        private double cambio;

        public int Precio { get => precio; set => precio = value; }
        public int Cantidad_coca { get => cantidad_coca; set => cantidad_coca = value; }
        public int Cantidad_fresca { get => cantidad_fresca; set => cantidad_fresca = value; }
        public int Cantidad_fanta { get => cantidad_fanta; set => cantidad_fanta = value; }
        public int Cantidad_sprite { get => cantidad_sprite; set => cantidad_sprite = value; }
        public int Cantidad_manzanita { get => cantidad_manzanita; set => cantidad_manzanita = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public double Cambio { get => cambio; set => cambio = value; }






    }
}
