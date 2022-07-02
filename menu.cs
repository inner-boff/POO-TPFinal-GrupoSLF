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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            personalizarDiseño();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void personalizarDiseño()
        {
            panelSubMenu.Visible = false;
            
        }
        private void ocutarSubMenu()
        {
            if (panelSubMenu.Visible == true)
                panelSubMenu.Visible = false;

        }
        
        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocutarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #region submenu1
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenu); 
        }

        private void bntIngreso_Click(object sender, EventArgs e)
        {
            abrirFormuarioSecundario(new AppPrincipal());
        }

        private void bntSalida_Click(object sender, EventArgs e)
        {
            abrirFormuarioSecundario(new SalidaDeVehiculo());
        }
        #endregion
        private void bntAyuda_Click(object sender, EventArgs e)
        {
            ocutarSubMenu();
        }
        private Form formularioActivo = null;
        private void abrirFormuarioSecundario(Form formSecundario)
        {
            if (formularioActivo != null)
                //ActiveForm.Close();
                formularioActivo = formSecundario;
            formSecundario.TopLevel = false;
            formSecundario.FormBorderStyle = FormBorderStyle.None;
            formSecundario.Dock = DockStyle.Fill;
            panelSecundario.Controls.Add(formSecundario);
            panelSecundario.Tag = formSecundario;
            formSecundario.BringToFront();
            formSecundario.Show();
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void menu_Load(object sender, EventArgs e)
        {
            
        }
    }
     
}
