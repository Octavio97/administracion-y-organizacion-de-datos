using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Envios
{
    public partial class Chofer : Form
    {
        public Chofer()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnAceptar, "Aceptar");
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingresa distancia a recorrer(km)");
            this.ttMensaje.SetToolTip(this.txtTL, "Lugar de salida");
            this.ttMensaje.SetToolTip(this.txtTelefono, "Lugar de destino");
            this.ttMensaje.SetToolTip(this.txtDireccion, "Tiempo estimado(min)");
            this.ttMensaje.SetToolTip(this.btnRegresar, "Regresar a menu");
            this.ttMensaje.SetToolTip(this.btnBorrar, "Ingresa id para eliminar");
        }
        SqlConnection conectar = new SqlConnection(@"Data source =.\SQLEXPRESS;Initial catalog = mibase; integrated security = true");
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(agregar(textBox5.Text, txtNombre.Text, txtEdad.Text, txtGenero.Text, txtTL.Text, txtTelefono.Text, txtDireccion.Text));
            textBox5.Clear();
            txtDireccion.Clear();
            txtEdad.Clear();
            txtGenero.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtTL.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Envios en = new Envios();
            this.Hide();
            en.Show();
            conectar.Close();
            en.btnAceptar.Visible = false;
            en.txtUsuario.Visible = false;
            en.txtContraseña.Visible = false;
            en.lblUsuario.Visible = false;
            en.lblContraseña.Visible = false;
            en.btnMenu.Visible = true;
            en.btnExit.Visible = true;
        }
        public string agregar(string idr, string a, string b, string c, string d, string e, string f)
        {
            string agr = "Archivos guardados exitosamente";
            try
            {
                SqlCommand altas = new SqlCommand("Insert into Chofer  (id_chofer, nombre, edad, sexo, tipodelicencia, telefono, direccion) values(" + idr + ", '" + a + "', '" + b + "', '" + c + "', '" + d + "', '" + e + "', '" + f + "')", conectar);
                altas.ExecuteNonQuery();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Llene las casillas faltantes");
            }
            return agr;
        }

        private void Chofer_Load(object sender, EventArgs e)
        {
            conectar.Open();
        }

        public string eliminar(string a)
        {
            string arg = "Chofer eliminado";
            try
            {
                string bajas = "DELETE FROM Transporte WHERE id_transporte = @id_transporte";
                SqlCommand cmdins = new SqlCommand(bajas, conectar);
                cmdins.Parameters.Add("id_transporte", textBox5.Text);
                cmdins.ExecuteNonQuery();

                cmdins.Dispose();
                cmdins = null;
                textBox5.Clear();

                conectar.Close();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Llene las casillas faltantes");
            }
            return arg;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(eliminar(textBox5.Text));
            textBox5.Clear();
        }
    }
}
