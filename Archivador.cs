using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO20Junio2022
{
    internal class Archivador
    {
        // actualizar solo esta ruta segun el equipo
        string pathDocumentosImpresos = @"C:\Users\54113\OneDrive\Escritorio\VersionParaPresentar\POO\POO\DocumentosImpresos\";



        // NO modificar las rutas a partir de aquí
        string pathTicketsImpresos = @"TicketsDeIngreso\";
        string pathComprobantesImpresos = @"ComprobantesDePago\";
        string pathContadores = @"Contadores\";
        string pathBorradores = @"Borradores\";


        public string AsignarNombreArchivo(Documento docu)
        {

            if (docu is Ticket)
            {
                var pathTicket = $@"{pathDocumentosImpresos}{pathTicketsImpresos}";
                var nombreTicket = pathTicket + docu.Titulo + "-" + docu.IdDesdeArchivoTxt + ".txt";
                return nombreTicket;
            }
            else if (docu is Comprobante)
            {
                var pathComprobante = $@"{pathDocumentosImpresos}{pathComprobantesImpresos}";
                var nombreComprobante = pathComprobante + docu.Titulo + "-" + docu.IdDesdeArchivoTxt + ".txt";
                return nombreComprobante;
            }
            else
            {
                return "";
            }
        }

        public string AsignarNombreArchivo(Borrador borrador)
        {

                var pathBorrardor = $@"{pathDocumentosImpresos}{pathBorradores}";
                var nombreBorrador = pathBorrardor + borrador.TituloBorrador + "-" + borrador.IDesdeArchivoTxtBorrador + ".txt";
                return nombreBorrador;
          
        }

        public string PathDocumentosImpresos
        {
            get { return pathDocumentosImpresos; }
            //set { return pathDocumentosImpresos = value; }
        }


        public string PathTicketsImpresos
        {
            get { return pathTicketsImpresos; }
        }

        public string PathComprobantesImpresos
        {
            get { return pathComprobantesImpresos; }
        }

        public string PathContadores
        {
            get { return pathContadores; }
        }

       
        public string PathBorradores
        {
            get { return pathBorradores; }
        }
    }

   

}
