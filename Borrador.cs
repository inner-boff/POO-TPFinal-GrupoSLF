using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO20Junio2022
{
    internal class Borrador : IComportamientoIDs
    {
        // al imprimirse
        // genera un archivo de texto igual al Comprobante pero sin ID
        // como no hereda de documento, no incremente los ID al instanciarse

        double importeBorrador;
        //string identificadorCompuesto; 

        double horasTotalesBorrador;
        string tarifaAplicadaBorrador;


        // atributos sustitutos de los originales del Documento
        string tituloBorrador;

        int iDDesdeArchivoTxtBorrador;

        // Todo comprobante de pago está asociado a un ticket de ingreso
        // por eso el constructor pide el id del ticket a pagar.
        // el Borrador también, así que pide las mismas cosas pero sin
        // genarar id automático porque no hereda de documento

        public Borrador(string IdTicketAPagar)
        {
            tituloBorrador = "Comprobante de Pago";

            var calculadora = new Calculadora();

            var lectorDeDocumentos = new LectorDeDocumentos();

            var textoEntrada = lectorDeDocumentos.MostrarLinea(IdTicketAPagar, 5, "ticket");
            var textoTarifa = lectorDeDocumentos.MostrarLinea(IdTicketAPagar, 11, "ticket");

            var entrada = DateTime.Parse(textoEntrada);
            
            DateTime salida = DateTime.Now;
            var tarifaParaCalculo = Double.Parse(textoTarifa);

            horasTotalesBorrador = calculadora.CalcularHorasTotales(entrada, salida);

            importeBorrador = calculadora.CalcularImporteTotal(horasTotalesBorrador, tarifaParaCalculo);

           
            tarifaAplicadaBorrador = textoTarifa;


            iDDesdeArchivoTxtBorrador = this.GenerarID();


        }

        public int GenerarID()
        {
            
            var archivador = new Archivador();

            var lectorDocs = new LectorDeDocumentos();
            var ultimaLinea = lectorDocs.MostrarUltimaLinea($@"{archivador.PathDocumentosImpresos}{archivador.PathContadores}IdBorradores.txt");

            
            int valorUltimaLinea = int.Parse(ultimaLinea);
            
            var calculadora = new Calculadora();
            var nuevoValorId = calculadora.sumarIdentificadores(valorUltimaLinea, 1);

            
            string nuevaLinea = nuevoValorId.ToString();

            this.iDDesdeArchivoTxtBorrador = int.Parse(nuevaLinea);

            var escritorDocs = new Impresora();
            escritorDocs.imprimirUltimaLinea($@"{archivador.PathDocumentosImpresos}{archivador.PathContadores}IdBorradores.txt", nuevaLinea);

            return nuevoValorId;
        }

        public double HorasTotalesBorrador
        {
            get { return horasTotalesBorrador; }
            set { horasTotalesBorrador = value; }
        }

        public string TarifaAplicadaBorrador
        {
            get { return tarifaAplicadaBorrador; }
            set { tarifaAplicadaBorrador = value; }

        }

        public string TituloBorrador
        {
            get { return tituloBorrador; }
            set { tituloBorrador = value; }

        }

        public double ImporteBorrador
        {
            get { return importeBorrador; }
            set { importeBorrador = value; }

        }

        public int IDesdeArchivoTxtBorrador
        {
            get { return iDDesdeArchivoTxtBorrador; }
            set { iDDesdeArchivoTxtBorrador = value; }
        }

    }
}
