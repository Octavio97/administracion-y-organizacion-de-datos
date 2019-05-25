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
    public partial class Carga : Form
    {
        public Carga()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnAceptar, "Aceptar");
            this.ttMensaje.SetToolTip(this.txtContenido, "Ingrese contenido");
            this.ttMensaje.SetToolTip(this.txtDescripcion, "Agregue una pequeña descripcion del articulo");
            this.ttMensaje.SetToolTip(this.txtPeso, "Ingrese peso en gramos");
            this.ttMensaje.SetToolTip(this.txtTipo, "Ingrese tipo de paquete");
            this.ttMensaje.SetToolTip(this.btnRegresar, "Regresar a menu");
            this.ttMensaje.SetToolTip(this.btnBorrar, "Ingresa id para eliminar");
        }
        SqlConnection conectar = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial catalog = mibase; Integrated security = true");
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(agregar(textBox5.Text, txtTipo.Text, txtPeso.Text, txtContenido.Text, txtDescripcion.Text));
            textBox5.Clear();
            txtContenido.Clear();
            txtDescripcion.Clear();
            txtPeso.Clear();
            txtTipo.Clear();
        }
        public string agregar(string idr, string a, string b, string c, string d)
        {
            string agr = "Archivos guardados exitosamente";
            try
            {
                SqlCommand altas = new SqlCommand("Insert into Carga  (id_carga, tipo, peso, contenido, descripcion) values(" + idr + ", '" + a + "', '" + b + "', '" + c + "', '" + d + "')", conectar);
                altas.ExecuteNonQuery();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Llene las casillas faltantes");
            }
            return agr;
        }

        private void Carga_Load(object sender, EventArgs e)
        {
            conectar.Open();
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

        public string eliminar(string a)
        {
            string arg = "Carga eliminada";
            try
            {
                string bajas = "DELETE FROM Carga WHERE id_carga = @id_carga";
                SqlCommand cmdins = new SqlCommand(bajas, conectar);
                cmdins.Parameters.Add("id_carga", textBox5.Text);
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
