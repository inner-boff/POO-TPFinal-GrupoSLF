using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO20Junio2022
{
    internal class Ticket : Documento //, IComportamientoIDs
    {
        string patente;
        string tipoVehiculo;
        string tarifaPorHora;
        //Tarifa precioHora;
        

        public Ticket()
        {
            Titulo = "Ticket de Ingreso";
            
            patente = "******"; // Se ingresa en el Form
                                // Puede haber una excepción para que
                                // no pueda quedar vacío el campo

            tipoVehiculo = ""; // igual que patente

            // descomentar para usar la interfaz
            //this.IdDesdeArchivoTxt = GenerarID();
        }


        // descomentar para usar la interfaz

        /* 
        public int GenerarID()
        {

            var archivador = new Archivador();

            var lectorDocs = new LectorDeDocumentos();
            var ultimaLinea = lectorDocs.MostrarUltimaLinea($@"{archivador.PathDocumentosImpresos}{archivador.PathContadores}IdTickets.txt");


            int valorUltimaLinea = int.Parse(ultimaLinea);

            var calculadora = new Calculadora();
            var nuevoValorId = calculadora.sumarIdentificadores(valorUltimaLinea, 1);


            string nuevaLinea = nuevoValorId.ToString();

            //this.iDDesdeArchivoTxtBorrador = int.Parse(nuevaLinea);

            var escritorDocs = new Impresora();
            escritorDocs.imprimirUltimaLinea($@"{archivador.PathDocumentosImpresos}{archivador.PathContadores}IdBorradores.txt", nuevaLinea);

            return nuevoValorId;
        }

        */

        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }

        public string TipoVehiculo
        {
            get { return tipoVehiculo; }
            set { tipoVehiculo = value; }
        }

        public string TarifaPorHora
        {
            get { return tarifaPorHora; }
            set { tarifaPorHora = value; }
        }


    }
}
