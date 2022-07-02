using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO20Junio2022
{
    internal class Impresora
    {
        
        public void imprimir(Ticket ticket) 
        {
            var archivador = new Archivador();
            var nombreTic = archivador.AsignarNombreArchivo(ticket);
            var nuevoTicket = new StreamWriter(nombreTic);

           
            // Lo que se imprime en el ticket:
                nuevoTicket.WriteLine($"*** {ticket.Titulo} ***");  // linea 1
                nuevoTicket.WriteLine($"Codigo identificador:");    // linea 2
                nuevoTicket.WriteLine($"{ticket.IdDesdeArchivoTxt}");    // linea 3
                nuevoTicket.WriteLine($"Fecha y hora de entrada:"); // linea 4
                nuevoTicket.WriteLine($"{ticket.Fecha}");           // linea 5
                nuevoTicket.WriteLine($"Patente del vehiculo:");    // linea 6
                nuevoTicket.WriteLine($"{ticket.Patente}");         // linea 7
                nuevoTicket.WriteLine($"Tipo de vehiculo:");        // linea 8
                nuevoTicket.WriteLine($"{ticket.TipoVehiculo}");    // linea 9
                nuevoTicket.WriteLine($"Tarifa por hora:");         // linea 10
                nuevoTicket.WriteLine($"{ticket.TarifaPorHora}");   // linea 11
            

            nuevoTicket.Close();

        }

        public void imprimir(Comprobante comprobante)
        {
            var archivador = new Archivador();
            var nombreComp = archivador.AsignarNombreArchivo(comprobante);
            var nuevoComp = new StreamWriter(nombreComp);

            // Lo que se imprime en el comprobante:
            nuevoComp.WriteLine($"*** {comprobante.Titulo} ***");   // linea 1
            nuevoComp.WriteLine($"Codigo identificador :");         // linea 2
            nuevoComp.WriteLine($"{comprobante.IdentificadorCompuesto}"); // linea 3
            nuevoComp.WriteLine($"Fecha y hora de salida:");        // linea 4
            nuevoComp.WriteLine($"{comprobante.Fecha}");            // linea 5
            nuevoComp.WriteLine($"Estadía en horas:");              // linea 6
            nuevoComp.WriteLine($"{comprobante.HorasTotales}");     // linea 7
            nuevoComp.WriteLine($"Tarifa Aplicada:");               // linea 8
            nuevoComp.WriteLine($"{comprobante.TarifaAplicada}");   // linea 9
            nuevoComp.WriteLine($"Importe a pagar:");               // linea 10
            nuevoComp.WriteLine($"{comprobante.Importe}");          // linea 11
            // falta agregar medio de pago
            nuevoComp.WriteLine("-- Gracias por elegirnos --");     // linea 12

            nuevoComp.Close();

        }

        
        public void imprimirUltimaLinea(string rutaDocumento, string nuevaLinea)
        {
            var escritor = new StreamWriter(rutaDocumento);
            escritor.WriteLine(nuevaLinea);
            escritor.Close();

        }

        public void imprimir(Borrador borrador)
        {
            var archivador = new Archivador();
            var nombreComp = archivador.AsignarNombreArchivo(borrador);
            var nuevoComp = new StreamWriter(nombreComp);

            // Lo que se imprime en el comprobante:
            nuevoComp.WriteLine($"*** {borrador.TituloBorrador} ***");   // linea 1
            nuevoComp.WriteLine($"Codigo identificador :");         // linea 2
            nuevoComp.WriteLine($"vacio - solo en comprobante impreso");                          // linea 3
            nuevoComp.WriteLine($"Fecha y hora de salida:");        // linea 4
            nuevoComp.WriteLine($"vacio");            // linea 5
            nuevoComp.WriteLine($"Estadía en horas:");              // linea 6
            nuevoComp.WriteLine($"{borrador.HorasTotalesBorrador}");     // linea 7
            nuevoComp.WriteLine($"Tarifa Aplicada:");               // linea 8
            nuevoComp.WriteLine($"{borrador.TarifaAplicadaBorrador}");   // linea 9
            nuevoComp.WriteLine($"Importe a pagar:");               // linea 10
            nuevoComp.WriteLine($"{borrador.ImporteBorrador}");          // linea 11
            // falta agregar medio de pago
            nuevoComp.WriteLine("-- Gracias por elegirnos --");     // linea 12

            nuevoComp.Close();

        }


    }
}
