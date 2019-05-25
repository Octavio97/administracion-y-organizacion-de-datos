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

namespace proyecto_organizacion_de_archivos
{
    public partial class frmPagina_web : Form
    {
        public string x;
        SqlConnection conexion = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = pagweb; Integrated Security = True");

        public frmPagina_web()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnaltas, "Guardar pagina");
            toolTip1.SetToolTip(button2, "Ingrese el id para eliminar");
            toolTip1.SetToolTip(button3, "Consultar pagina");
            toolTip1.SetToolTip(button4, "Ingresa id para modificarla");
            toolTip1.SetToolTip(button5, "Regresar");           
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            frmmenu obj = new frmmenu();
            obj.Show();
            this.Hide();
            conexion.Close();
        }

        private void btnaltas_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show(altas(idpag.Text, txtnom.Text, txturl.Text, comboBox2.Text, txtconsulta.Text, txtdesc.Text, txttiempo.Text, comboBox1.Text));
            idpag.Clear();
            txtnom.Clear();
            txturl.Clear();
            txtconsulta.Clear();
            txtdesc.Clear();
            txttiempo.Clear();
            comboBox1.Text.Equals("");
            comboBox2.Text.Equals("");
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show(bajas(idpag.Text));
            idpag.Clear();
            txtnom.Clear();
            txturl.Clear();
            txtconsulta.Clear();
            txtdesc.Clear();
            txttiempo.Clear();
            comboBox1.Text.Equals("");
            comboBox2.Text.Equals("");
            conexion.Close();
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show(consultas(idpag.Text, txtnom.Text, txturl.Text, comboBox2.Text, txtconsulta.Text, txtdesc.Text, txttiempo.Text, comboBox1.Text));
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show(modificaciones(idpag.Text, txtnom.Text, txturl.Text, comboBox2.Text, txtconsulta.Text, txtdesc.Text, txttiempo.Text,comboBox1.Text));
            idpag.Clear();
            txtnom.Clear();
            txturl.Clear();
            txtconsulta.Clear();
            txtdesc.Clear();
            txttiempo.Clear();
            comboBox1.Text.Equals("");
            comboBox2.Text.Equals("");
            conexion.Close();
            conexion.Close();
        }

        public string altas(string a, string b, string c, string d, string e, string f, string g, string h)
        {
            string arg;
            if(txtconsulta.Text == "" || txtdesc.Text == "" || txtnom.Text == "" || txttiempo.Text == "" || txturl.Text == "" || comboBox1.Text == ""|| comboBox2.Text == "")
            {
                arg = "Llene las casillas para que su pagina sea guardada";
            }
            else
            {
                try
                {
                    SqlCommand alta = new SqlCommand("Insert into pagina(id_web, nombre, direccion, valoracion, fecha, descripcion, tiempo, categoria) values(" + a + ", '" + b + "', '" + c + "',  '" + d + "', '" + e + "', '" + f + "', '" + g + "', '" + h + "')", conexion);
                    alta.ExecuteNonQuery();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("ERROR");
                }
                arg = "Pagina guardada";
            }
            return arg;
        }

        public string bajas(string a)
        {
            string arg = "Ingrese id para que su pagina web sea eliminada";
            recorrido(idpag.Text);

            if(idpag.Text != "")
            {
                try
                {
                    if (a == x)
                    {
                        string baja = "DELETE FROM pagina WHERE id_web = @id_web";

                        SqlCommand cmdins = new SqlCommand(baja, conexion);
                        cmdins.Parameters.AddWithValue("id_web", a);
                        cmdins.ExecuteNonQuery();

                        cmdins.Dispose();
                        cmdins = null;
                        idpag.Clear();
                        arg = "Pagina eliminada";
                    }
                    else
                    {
                        arg = "El id no existe o ya ha sido eliminado";
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("ERROR");
                }
            }
            return arg;
        }

        public string consultas(string a, string b, string c, string d, string e, string f, string g, string h)
        {
            string arg = "Pagina no encontrada";

            if(idpag.Text == "" && comboBox1.Text == "" && txtnom.Text =="" && txturl.Text == "" && comboBox2.Text == "" && txtconsulta.Text == "" && txtdesc.Text == "" && txttiempo.Text == "")
            {
                arg = "Ingrese algun campo para encontrar su pagina";
            }
            else
            {
                SqlCommand consulta = new SqlCommand(string.Format("Select * from pagina as p where p.id_web like '%{0}%' and p.nombre like '%{1}%' and p.direccion like '%{2}%' and p.valoracion like '%{3}%' and p.fecha like '%{4}%' and p.descripcion like '%{5}%' and p.tiempo like '%{6}%' and p.categoria like '%{7}%'", a, b, c, d, e, f, g, h), conexion);

                SqlDataReader Read = consulta.ExecuteReader();

                while (Read.Read())
                {
                    idpag.Text = Read.GetString(0);
                    txtnom.Text = Read.GetString(1);
                    txturl.Text = Read.GetString(2);
                    comboBox2.Text = Read.GetString(3);
                    txtconsulta.Text = Read.GetString(4);
                    txtdesc.Text = Read.GetString(5);
                    txttiempo.Text = Read.GetString(6);
                    comboBox1.Text = Read.GetString(7);
                    arg = "Pagina encontrada";
                }
            }
            return arg;
        }

        public string modificaciones(string a, string b, string c, string d, string e, string f, string g, string h)
        {
            int retorno = 0;
            string arg;
            recorrido(idpag.Text);

            if (idpag.Text == "" || idpag.Text != x)
            {
                arg = "Ingrese id para poder modificar su pagina web";
            }
            else
            {
                try
                {
                    SqlCommand modificar = new SqlCommand(string.Format("Update pagina set nombre = '{0}', direccion = '{1}', valoracion = '{2}', fecha = '{3}', descripcion = '{4}', tiempo = '{5}', categoria = '{6}' where id_web = '{7}'", b, c, d, e, f, g, h, a), conexion);
                    retorno = modificar.ExecuteNonQuery();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("ERROR");
                }
                arg = "Pagina modificada";
            }
            return arg;
        }

        private void frmPagina_web_Load(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand c = new SqlCommand("Select nombre from categoria", conexion);
            SqlDataReader read = c.ExecuteReader();

            while (read.Read())
            {
                comboBox1.Items.Add(read.GetString(0));
                comboBox1.DisplayMember = "nombre"; 
            }
            conexion.Close();
        }

        public void recorrido(string a)
        {
            SqlCommand consulta = new SqlCommand(string.Format("Select id_web from pagina as p where p.id_web like '{0}' ", a), conexion);

            SqlDataReader Read = consulta.ExecuteReader();

            while (Read.Read())
            {
                x = Read.GetValue(0).ToString();
            }
            Read.Close();
        }
    }
}
