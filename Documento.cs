using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO20Junio2022
{
    internal class Documento : IComportamientoIDs
    {
        string titulo;

        DateTime fecha;
 
        int idDesdeArchivoTxt;


        public Documento() 
        {
            titulo = "";

            // descomentar para que enganche la interfaz
            idDesdeArchivoTxt = this.GenerarID();

            //idDesdeArchivoTxt = 0; // que se actualice al implementar la interfaz
                                   // en Ticket y Comprobante respectivamente

            fecha = DateTime.Now;
            
            
        }

        public int GenerarID()
        {
            
            // se llama a un Archivador para poder llamar las rutas como atributo
            var archivador = new Archivador();

            // Para inicializar int idDesdeArchivoTxt;
            // Llamammos un nuevo lector de documentos
            // para leer la ultima linea con la funcion correspondiente

            var lectorDocs = new LectorDeDocumentos();
            var ultimaLinea = lectorDocs.MostrarUltimaLinea($@"{archivador.PathDocumentosImpresos}{archivador.PathContadores}IdDocumentos.txt");

            // convierte ese valor en int
            int valorUltimaLinea = int.Parse(ultimaLinea);
            // le suma uno para tener el nuevo valor


            // Se llama una nueva calculadora
            // se llama la funcion que toma un valor y le suma una cantidad asignada
            var calculadora = new Calculadora();
            var nuevoValorId = calculadora.sumarIdentificadores(valorUltimaLinea, 1);

            string nuevaLinea = nuevoValorId.ToString();

            this.idDesdeArchivoTxt = int.Parse(nuevaLinea);

            var escritorDocs = new Impresora();
            escritorDocs.imprimirUltimaLinea($@"{archivador.PathDocumentosImpresos}{archivador.PathContadores}IdDocumentos.txt", nuevaLinea);

            return nuevoValorId;
        }

        public int IdDesdeArchivoTxt
        {
            get { return idDesdeArchivoTxt; }
            set { idDesdeArchivoTxt = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


    }

}
