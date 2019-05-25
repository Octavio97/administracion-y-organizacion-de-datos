using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Envios
{
    public partial class Envios : Form
    {
        public Envios()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnAceptar, "Aceptar");
            this.ttMensaje.SetToolTip(this.txtContraseña, "Ingresa contraseña");
            this.ttMensaje.SetToolTip(this.txtUsuario, "Ingresa usuario");
            this.ttMensaje.SetToolTip(this.btnCarga, "Nueva carga");
            this.ttMensaje.SetToolTip(this.btnTransporte, "Nuevo transporte");
            this.ttMensaje.SetToolTip(this.btnChofer, "Nuevo chofer");
            this.ttMensaje.SetToolTip(this.btnRuta, "Nueva ruta");
            this.ttMensaje.SetToolTip(this.btnMenu, "Menu");
            this.ttMensaje.SetToolTip(this.btnExit, "Salir");
        }
        
        bool bandera = true;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Juan" && txtContraseña.Text == "hola")
            {
                btnMenu.Visible = true;
                lblContraseña.Visible = false;
                lblUsuario.Visible = false;
                txtContraseña.Visible = false;
                txtUsuario.Visible = false;
                btnAceptar.Visible = false;
                btnExit.Visible = true;
            }
            else
            {
                MessageBox.Show("Ingrese un usuario o  contraseña correctos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                btnChofer.Visible = true;
                btnCarga.Visible = true;
                btnRuta.Visible = true;
                btnTransporte.Visible = true;
                bandera = false;
            }
            else
            {
                btnChofer.Visible = false;
                btnCarga.Visible = false;
                btnRuta.Visible = false;
                btnTransporte.Visible = false;
                bandera = true;
            }
        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            Transporte tr = new Transporte();
            this.Hide();
            tr.Show();
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            Ruta rt = new Ruta();
            this.Hide();
            rt.Show();
        }

        private void btnChofer_Click(object sender, EventArgs e)
        {
            Chofer cr = new Chofer();
            this.Hide();
            cr.Show();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            Carga ca = new Carga();
            this.Hide(); 
            ca.Show();                  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
