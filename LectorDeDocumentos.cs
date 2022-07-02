using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO20Junio2022
{
    internal class LectorDeDocumentos 
    {

        StreamReader? docALeer;

        public string MostrarLinea(string IdDocumentoALeer, int numLinea, string tipoDocumento)
        {
            string lineaAmostrar;

            var archivador = new Archivador();

            if (tipoDocumento == "ticket")
            {

                docALeer = new StreamReader($@"{archivador.PathDocumentosImpresos}{archivador.PathTicketsImpresos}Ticket de Ingreso-{IdDocumentoALeer}.txt");
            }
            else if (tipoDocumento == "comprobante")
            {

                docALeer = new StreamReader($@"{archivador.PathDocumentosImpresos}{archivador.PathComprobantesImpresos}Comprobante de Pago-{IdDocumentoALeer}.txt");
            }

            for (int i = 1; i < numLinea; i++) // el loop empieza en 1
                                               // y para justo antes
                                               // de la linea que se 
                                               // quiere guardar
            {
                docALeer.ReadLine();
            }

            lineaAmostrar = docALeer.ReadLine();

            docALeer.Close();

            return lineaAmostrar.ToString();
            
        }
        public string leerArchivoOrigen(string nombre)
        {
            string linea;

            var archivador = new Archivador();

            var readContador = new StreamReader($@"{archivador.PathDocumentosImpresos}{archivador.PathContadores}{nombre}.txt");
            linea = readContador.ReadLine();
            readContador.Close();

            if(nombre == "contadorAutos" && linea == null)
            {
                return linea = "40";
            }
            if(nombre == "contadorMotos" && linea == null)
            {
                return linea = "20";
            }
            return linea;
                                    
        }

        public void escribirArchivoDestino(string nombre, int cantidad)
        {
            var archivador = new Archivador();
            var writeContador = new StreamWriter($@"{archivador.PathDocumentosImpresos}{archivador.PathContadores}{nombre}.txt");
            writeContador.WriteLine(cantidad);
            writeContador.Close();
        }

        public string MostrarUltimaLinea(string rutaDocALeer) {

            string ultimaLinea;

            ultimaLinea = File.ReadLines(rutaDocALeer).Last();

            return ultimaLinea;
        }

    }
}

