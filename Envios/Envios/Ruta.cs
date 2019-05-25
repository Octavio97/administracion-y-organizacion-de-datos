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
    public partial class Ruta : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=mibase;Integrated Security=True");
        public Ruta()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnAceptar, "Aceptar");
            this.ttMensaje.SetToolTip(this.textBox1, "Ingresa distancia a recorrer(km)");
            this.ttMensaje.SetToolTip(this.textBox2, "Ingrese lugar de salida");
            this.ttMensaje.SetToolTip(this.textBox3, "Ingrese lugar de destino");
            this.ttMensaje.SetToolTip(this.textBox4, "Ingrese tiempo estimado en minutos");
            this.ttMensaje.SetToolTip(this.btnRegresar, "Regresar a menu");
            this.ttMensaje.SetToolTip(this.btnBorrar, "Ingresa id para eliminar");
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(agregar(textBox5.Text, textBox1.Text, textBox4.Text, textBox2.Text, textBox3.Text));
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
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
        public string agregar(string idr, string a, string b, string c, string d)
        {
            string agr = "Archivos guardados exitosamente";
            try
            {               
                SqlCommand altas = new SqlCommand ("Insert into Ruta  (id_ruta, Distancia, Tiempo_estimado, lsalida, Destino) values("+idr+", '"+a+"', '"+b+"', '"+c+"', '"+d+"')", conectar);
                altas.ExecuteNonQuery();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Llene las casillas faltantes");
            }
            return agr;
        }

        private void Ruta_Load(object sender, EventArgs e)
        {
            conectar.Open();
        }

        public string eliminar(string a)
        {
            string arg = "Ruta eliminada";
            try
            {
                string bajas = "DELETE FROM Ruta WHERE id_ruta = @id_ruta";
                SqlCommand cmdins = new SqlCommand(bajas, conectar);
                cmdins.Parameters.Add("id_ruta", textBox5.Text);
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
