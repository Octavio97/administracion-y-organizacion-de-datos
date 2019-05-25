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
    public partial class frmcategoria : Form
    {
        public string x;

        public frmcategoria()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnaltas,"Guardar categoria");
            toolTip1.SetToolTip(button2, "Eliminar categoria");
            toolTip1.SetToolTip(button3, "Consultar categoria");
            toolTip1.SetToolTip(button4, "Modificar categoria");
            toolTip1.SetToolTip(button5, "Regresar");
        }

        public SqlConnection conexion = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = pagweb; Integrated Security = True");

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
            MessageBox.Show(altas(txtidcate.Text, txtnomcate.Text, txtfecha.Text));
            txtidcate.Clear();
            txtnomcate.Clear();
            txtfecha.Clear();
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show(bajas(txtidcate.Text));
            txtidcate.Clear();
            txtnomcate.Clear();
            txtfecha.Clear();
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show(consultas(txtidcate.Text, txtnomcate.Text, txtfecha.Text));
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show(modificaciones(txtidcate.Text, txtnomcate.Text, txtfecha.Text));
            txtidcate.Clear();
            txtnomcate.Clear();
            txtfecha.Clear();
            conexion.Close();
        }

        public string altas(string a, string b, string c)
        {
            string arg = "Llene las casillas para que su categoria sea guardada";
            recorrido(txtidcate.Text);

            if (txtfecha.Text != "" || txtidcate.Text != "" || txtnomcate.Text != "")
            {
                try
                {
                    SqlCommand alta = new SqlCommand("Insert into categoria (id_cat, nombre, fecha) values(" + a + ", '" + b + "', '" + c + "')", conexion);
                    if (x == a)
                    {
                        arg = "Id existente";
                    }
                    else
                    {
                        alta.ExecuteNonQuery();
                        arg = "Categoria guardada";
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("ERROR");
                }
            }
            return arg;
        }

        public string bajas(string a)
        {
            string arg = "Ingrese el id para que su categoria sea eliminada";
            recorrido(txtidcate.Text);

            if(txtidcate.Text != "")
            {
                try
                {
                    if (x == a)
                    {
                        string baja = "DELETE FROM categoria WHERE id_cat = @id_cat";

                        SqlCommand cmdins = new SqlCommand(baja, conexion);
                        cmdins.Parameters.AddWithValue("id_cat", a);

                        cmdins.ExecuteNonQuery();

                        cmdins.Dispose();
                        cmdins = null;
                        txtidcate.Clear();
                        arg = "Categoria eliminada";
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

        public string consultas(string a, string b, string c)
        {
            string arg = "Categoria no encontrada";
            if (a == "" && b == "" && c == "")
            {
                arg = "Ingrese algun campo para encontrar su categoria";
            }
            else
            {
                SqlCommand consulta = new SqlCommand(string.Format("Select * from categoria as p where p.id_cat like '%{0}%'", a, b, c), conexion);
                
                SqlDataReader Read = consulta.ExecuteReader();

                while (Read.Read())
                {
                    txtidcate.Text = Read.GetValue(0).ToString();
                    txtnomcate.Text = Read.GetValue(1).ToString();
                    txtfecha.Text = Read.GetValue(2).ToString();
                    arg = "Categoria encontrada";
                }
            }
            return arg;
        }

        public string modificaciones(string a, string b, string c)
        {
            int retorno = 0;
            string arg;
            recorrido(txtidcate.Text);

            if (txtidcate.Text == "" || txtidcate.Text != x)
            {
                arg = "Ingrese id valido para modificar su categoria";
            }
            else
            {
                try
                {
                    SqlCommand modificar = new SqlCommand(string.Format("Update categoria set nombre = '{0}', fecha = '{1}'  where id_cat = '{2}'", b, c, a), conexion);
                    retorno = modificar.ExecuteNonQuery();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("ERROR");
                }
                arg = "Categoria modificada";
            }
            return arg;
        }

        public void recorrido(string a)
        {
            SqlCommand consulta = new SqlCommand(string.Format("Select id_cat from categoria where id_cat like '{0}'", a), conexion);

            SqlDataReader Read = consulta.ExecuteReader();

            while (Read.Read())
            {
                x = Read.GetValue(0).ToString();
            }
            Read.Close();
        }
    }
}
