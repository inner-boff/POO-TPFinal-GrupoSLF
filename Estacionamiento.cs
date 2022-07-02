using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO20Junio2022
{
    internal class Estacionamiento
    {
        string cantMotos;
        string cantAutos;
    

        public string cantidadMotos()
        {
                string nombre = "contadorMotos";
                var numero = new LectorDeDocumentos();
                this.cantMotos = numero.leerArchivoOrigen(nombre);
                    
            return cantMotos;
        }
        public string cantidadAutos()
        {
                string nombre = "contadorAutos";
                var numero = new LectorDeDocumentos();
                this.cantAutos = numero.leerArchivoOrigen(nombre);
         
            return cantAutos;
        }
    }

}
