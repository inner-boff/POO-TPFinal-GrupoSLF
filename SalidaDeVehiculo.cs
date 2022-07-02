using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO20Junio2022
{
    public partial class SalidaDeVehiculo : Form
    {
        public SalidaDeVehiculo()
        {
            InitializeComponent();
            var estacionamiento = new Estacionamiento();
            labelCantVehiculos.Text = estacionamiento.cantidadAutos();
            labelCantMotos.Text = estacionamiento.cantidadMotos();
        }

        // lógica del boton que genera un nuevo comprobante y
        // muestra los datos del comprobante
        private void buttonMostrarDatosComprobante_Click(object sender, EventArgs e)
        {

            try
            {

                var borrador = new Borrador(textBoxIDTicketAPagar.Text);
                var impresora = new Impresora();

                // Llamar a un lector de documentos
                var lector = new LectorDeDocumentos();
                // datos del ticket:
                labelIdTicket.Text = lector.MostrarLinea(textBoxIDTicketAPagar.Text, 3, "ticket");
                labelFechayHoraEntrada.Text = lector.MostrarLinea(textBoxIDTicketAPagar.Text, 5, "ticket");
                labelPatente.Text = lector.MostrarLinea(textBoxIDTicketAPagar.Text, 7, "ticket");
                labelTipoVehiculo.Text = lector.MostrarLinea(textBoxIDTicketAPagar.Text, 9, "ticket");
                labelTarifa.Text = lector.MostrarLinea(textBoxIDTicketAPagar.Text, 11, "ticket");

                // datos del BORRADOR
                labelFechaYHoraSalida.Text = DateTime.Now.ToString(); //lector.MostrarLinea(textBoxIDTicketAPagar.Text, 5, "comprobante");
                labelEstadiaHoras.Text = borrador.HorasTotalesBorrador.ToString(); //lector.MostrarLinea(textBoxIDTicketAPagar.Text, 7, "comprobante");
                labelMonto.Text = borrador.TarifaAplicadaBorrador.ToString();//lector.MostrarLinea(textBoxIDTicketAPagar.Text, 11, "comprobante");
                // falta agregar el medio de pago a la impresión del comprobante
                // por ahora lo muestra referenciado del menu de la forma:
                labelMedioDePago.Text = comboBox1.Text;

                // imprime el borardor en la carpeta correspodinte
                impresora.imprimir(borrador);

            }
            catch
            {
                // Se está disparando esta excepción aunque el ticket sea válido
                // Descomentae¿r si se resuelve
                // Sustituir por un mensaje genérico:
                // "Se previsualizará el ticket elegido"
                //MessageBox.Show("El numero de ticket no es válido, ingrese un número válido");
                MessageBox.Show("Se previsualizará el ticket elegido");
            }

        }

        // lógica del boton que confirma el pago
        private void button1_Click(object sender, EventArgs e)
        {
            // crea un nuevo comprobante a partir del id 
            // del ticket correspondiente
            var nuevoComprobantePago = new Comprobante(textBoxIDTicketAPagar.Text);
            var impresoraDeComprobante = new Impresora();

            // imprime el comprobante y lo guarda en el directorio asignado
            impresoraDeComprobante.imprimir(nuevoComprobantePago);

            MessageBox.Show("Pago exitoso - Puede ver los comprobantes impresos en la carpeta de Comprobantes de Pagos en Documentos Impresos");

            //instancia de un nuevo objeto calculadora para llamar a los métodos
            // sumarCantVehiculos
            var sumarVehiculos = new Calculadora();
            var gestorArchivos = new LectorDeDocumentos();
            var menuPrincipal = new menu();
          
            // Realiza la cuenta tomando como referencia el label del tipo de vehiculo y escribe en el archivo
            if (labelTipoVehiculo.Text == "moto")
            {
                string nombre = "contadorMotos";
                string cantidad = gestorArchivos.leerArchivoOrigen(nombre);
                string numeroMotos = sumarVehiculos.sumarCantVehiculos(labelTipoVehiculo.Text, cantidad).ToString();
                labelCantMotos.Text = numeroMotos;
            }
            if (labelTipoVehiculo.Text == "auto" || labelTipoVehiculo.Text == "camioneta")
            {
                string nombre = "contadorAutos";
                string cantidad = gestorArchivos.leerArchivoOrigen(nombre);
                string numeroAutos = sumarVehiculos.sumarCantVehiculos(labelTipoVehiculo.Text, cantidad).ToString();
                labelCantVehiculos.Text = numeroAutos;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            var pantallaAppPrincipal = new AppPrincipal();
            this.Hide(); // lo oculta pero sigue activo
            pantallaAppPrincipal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
