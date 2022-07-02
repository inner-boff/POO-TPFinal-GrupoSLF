using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO20Junio2022
{
    internal class Tarifa
    {
        
        double precioHora;

        /* 
        public Tarifa(double precioHora)
        {
            this.precioHora = precioHora;
        }
        */

        // hardocodeado por ahora,
        // Deberia haber una clase para cada tipo de vehiculo

        public Tarifa(string tipoVehiculo)
        {
              if (tipoVehiculo == "auto")
            {
                precioHora = 200;
            }
            else if (tipoVehiculo == "moto")
            {
                precioHora = 100;
            }
            else if (tipoVehiculo == "camioneta")
            {
                precioHora = 250;
            }
            
        }

        public double PrecioHora
        {
            get { return precioHora; }
            set { precioHora = value; }
        }
    }
}
