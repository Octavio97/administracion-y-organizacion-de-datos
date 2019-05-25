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
    public partial class Transporte : Form
    {
        public Transporte()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnAceptar, "Aceptar");
            this.ttMensaje.SetToolTip(this.textBox1, "Ingresar marca del vehiculo");
            this.ttMensaje.SetToolTip(this.textBox2, "Ingresar modelo del vehiculo");
            this.ttMensaje.SetToolTip(this.textBox3, "Ingresar tipo de transporte");
            this.ttMensaje.SetToolTip(this.textBox4, "Ingresar serie del vehiculo");
            this.ttMensaje.SetToolTip(this.btnRegresar, "Regresar a menu");
            this.ttMensaje.SetToolTip(this.btnBorrar, "Ingresa id para eliminar");
        }
        SqlConnection conectar = new SqlConnection(@"Data source =.\SQLEXPRESS;Initial catalog = mibase; integrated security = true");
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(agregar(textBox5.Text, textBox1.Text, textBox4.Text, textBox2.Text, textBox3.Text));
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void Transporte_Load(object sender, EventArgs e)
        {
            conectar.Open();
        }
       
        public string agregar(string idr, string a, string b, string c, string d)
        {
            string agr = "Archivos guardados exitosamente";
            try
            {
                SqlCommand altas = new SqlCommand("Insert into Transporte  (id_transporte, marca, serie, modelo, tipo) values(" + idr + ", '" + a + "', '" + b + "', '" + c + "', '" + d + "')", conectar);
                altas.ExecuteNonQuery();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Llene las casillas faltantes");
            }
            return agr;
        }

        public string eliminar(string a)
        {
            string arg = "Transporte eliminado";
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
