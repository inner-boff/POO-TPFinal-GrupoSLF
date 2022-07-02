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
    public partial class AppPrincipal : Form
    {
        public AppPrincipal()
        {
            InitializeComponent();
            var estacionamiento = new Estacionamiento();
            label6.Text = estacionamiento.cantidadAutos();
            label8.Text = estacionamiento.cantidadMotos();
        }

        // lógica para el botón que imprime los tickets de ingreso:
        private void button1_Click(object sender, EventArgs e)
        {
            var nuevoTicket = new Ticket();
            var impresoraDeTicket = new Impresora();
            
            // la patente es ingresada por pantalla
            nuevoTicket.Patente = textBoxPatente.Text;

            // el tipo de vehiculo se ingresa por pantalla
            // toma el texto de la caja de opciones
            // es importante para determinar la tarifa
            nuevoTicket.TipoVehiculo = comboBox1.Text;
          
            // crea un nuevo objeto Tarifa segun el tipo de vehiculo
            // y queda asignada la tarifa apropiada
            var tarifa = new Tarifa(comboBox1.Text);
            nuevoTicket.TarifaPorHora = tarifa.PrecioHora.ToString();

            // imprime el ticket y lo guarda en el directorio asignado
            impresoraDeTicket.imprimir(nuevoTicket);

            var restarVehiculos = new Calculadora();
            var estacionamiento = new Estacionamiento();
            var menuPrincipal = new menu();
            
            if (textBoxPatente.Text == "")
            {
                MessageBox.Show("Debes ingresar una patente");
            }
            else if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un tipo de vehiculo");
            }
            else
            {
                              
                if (comboBox1.Text == "moto")
                {
                    int cantidad = Convert.ToInt32(estacionamiento.cantidadMotos());
                    if(cantidad > 0)
                    {
                        restarVehiculos.restarCantVehiculos(comboBox1.Text, estacionamiento.cantidadMotos());
                        label8.Text = estacionamiento.cantidadMotos();
                    }
                    else
                    {
                        MessageBox.Show("Lo siento, no hay más lugar para motos");
                    }
                }
                if (comboBox1.Text == "auto" || comboBox1.Text == "camioneta")
                {
                    int cantidad = Convert.ToInt32(estacionamiento.cantidadAutos());
                    if (cantidad > 0)
                    {
                        restarVehiculos.restarCantVehiculos(comboBox1.Text, estacionamiento.cantidadAutos());
                        label6.Text = estacionamiento.cantidadAutos();
                    }
                    else
                    {
                        MessageBox.Show("Lo siento, no hay más lugar para autos o camionetas");
                    }
                }
            }
            var menuP = new menu();
            menuP.Refresh();
        }


        // logica del boton que lleva a la pantalla de Salida / Pagos
        private void button3_Click(object sender, EventArgs e)
        {
            //var pantallaSalidasYPagos = new SalidaDeVehiculo();
            //this.Hide(); // lo oculta pero sigue activo
            //pantallaSalidasYPagos.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //var numeroMoto = new Estacionamiento();
            //labelCantVehiculos.Text = numeroMoto.cantidadMotos.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPatente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
