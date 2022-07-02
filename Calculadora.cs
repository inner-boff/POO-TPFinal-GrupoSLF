using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POO20Junio2022
{
    internal class Calculadora
    {
        
        public double CalcularHorasTotales(DateTime horaEntrada, DateTime horaSalida)
        
        {
            var horasTotales = (horaSalida - horaEntrada).TotalHours;
            var minutosTotales = (horasTotales % 1) * 60;

            horasTotales = ((int)horasTotales);
            minutosTotales =((int)minutosTotales);
          
            // Si la hora es menr a 1 se cobra una hora minimo

            if (horasTotales < 1)
            {
                return 1;
            }

            // Si los minutos no superan la media hora, se agrega una fraccion a la hora

            else if(minutosTotales < 31)
            {
                return horasTotales + 0.5;
            }

            // Si los minutos exceden la media hora, se agrega una hora entera

            else
            {
                return horasTotales + 1;
            }
           
        }
        public double CalcularImporteTotal(double horas, double tarifa)
        {
            double importe;
            importe = horas * tarifa;
            return importe;
        }

       
        public int restarCantVehiculos(string vehiculo, string cantidad)
        {
            var modificarArchivo = new LectorDeDocumentos();

            string nombre = "";
            int cantidadVehiculo = Convert.ToInt32(cantidad);
            cantidadVehiculo -= 1;

            if(vehiculo == "moto")
            {
                nombre = "contadorMotos";
            }
            else 
            {
                nombre = "contadorAutos";
            }

            modificarArchivo.escribirArchivoDestino(nombre, cantidadVehiculo);

            return cantidadVehiculo;
        }
        public int sumarCantVehiculos(string vehiculo, string cantidad)
        {
            var modificarArchivo = new LectorDeDocumentos();
            string nombre;

            if (vehiculo == "moto")
            {
                nombre = "contadorMotos";
            }
            else
            {
                nombre = "contadorAutos";
            }
            
            int cantidadVehiculo = Convert.ToInt32(cantidad);

            cantidadVehiculo += 1;


            modificarArchivo.escribirArchivoDestino(nombre, cantidadVehiculo);

            return cantidadVehiculo;
        }

        public int sumarIdentificadores(int valorInicial, int incremento)
        {
            int valorFinal;
            valorFinal = valorInicial + incremento;
            return valorFinal;
        }

    }
}
