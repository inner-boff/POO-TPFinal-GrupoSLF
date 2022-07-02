using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO20Junio2022
{
    internal class Comprobante : Documento
    {
        double importe;
        string identificadorCompuesto; // es un string que combina el id ticket
                                       // con el id del comprobante
                                       // solo aparece impreso en el comprobante
                                      
        double horasTotales;
        string tarifaAplicada;
        
        // Todo comprobante de pago está asociado a un ticket de ingreso
        // por eso el constructor pide el id del ticket a pagar.
        public Comprobante(string IdTicketAPagar)
        {
            this.Titulo = "Comprobante de Pago";

            this.IdentificadorCompuesto = IdTicketAPagar + "-" + this.IdDesdeArchivoTxt.ToString();


            // Con LectorDeDocumentos
            // Se llama a LectorDeDocumentos para recuperar
            // los datos necesarios del ticket

            var lectorDeDocumentos = new LectorDeDocumentos();

          
            var textoEntrada = lectorDeDocumentos.MostrarLinea(IdTicketAPagar, 5, "ticket");
            var textoTarifa = lectorDeDocumentos.MostrarLinea(IdTicketAPagar, 11, "ticket");

            

            // Datos para los calculos:
            // salida es un atributo del Compromante
            // entrada y tarifaParaClaculo vienen del ticket
            // via LectorDeDocumentos (StreamReader)

            var entrada = DateTime.Parse(textoEntrada);
            DateTime salida = this.Fecha;
            var tarifaParaCalculo = Double.Parse(textoTarifa);

            // la calculadora hace las cuentas con los datos obtenidos
            var calculadora = new Calculadora();

            horasTotales = calculadora.CalcularHorasTotales(entrada, salida);
            
            importe = calculadora.CalcularImporteTotal(horasTotales, tarifaParaCalculo);

            // Para imprimir en el comprobante
            tarifaAplicada = importe.ToString();

            

        }

        public double Importe
        {
            get { return importe; }
            set { importe = value; }
        }


        public string IdentificadorCompuesto
        {
            get { return identificadorCompuesto; }
            set { identificadorCompuesto = value; }
        }

        public double HorasTotales
        {
            get { return horasTotales; }
            set { horasTotales = value; }
        }

        public string TarifaAplicada
        {
            get { return tarifaAplicada; }
            set { tarifaAplicada = value; }
        }
    }
}
