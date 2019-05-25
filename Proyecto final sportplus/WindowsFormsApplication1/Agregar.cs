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

namespace WindowsFormsApplication1
{
    public partial class Agregar : Form
    {
        
        SqlConnection conexion = Conectar.conexion();
        public string bandera;
        public string x;
        public bool modif;

        #region forma actividades
        public Agregar()
        {
            InitializeComponent();
            toolTip1.SetToolTip(cmdaltas, "Guardar");
            toolTip1.SetToolTip(cmdbajas, "Cancelar");
        }

        private void cmdRegresar_Click(object sender, EventArgs e)
        {
            Datos d = new Datos();
            d.Show();
            this.Hide();
        }

        private void cmdbajas_Click(object sender, EventArgs e)
        {
            Datos d = new Datos();
            d.bandera = bandera;
            d.StartPosition = this.StartPosition;
            d.Show();
            this.Hide();
        }

        private void cmdaltas_Click(object sender, EventArgs e)
        {
            if (modif == true)
            {
                if (bandera == "Partido")
                {
                    MessageBox.Show(modificaciones(textBox7.Text, textBox1.Text, comboBox1.Text, comboBox2.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox3.Text));
                }
                else if (bandera == "Equipo")
                {
                    MessageBox.Show(modificaciones(textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, maskedTextBox1.Text, comboBox1.Text, "", ""));
                }
                else if (bandera == "Jugador")
                {
                    MessageBox.Show(modificaciones(textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, comboBox1.Text));
                }
                else if (bandera == "Liga")
                {
                    MessageBox.Show(modificaciones(textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, "", "", ""));
                }
                else
                {
                    MessageBox.Show("Ingrese alguna categoria");
                }
            }
            else
            {
                if (bandera == "Partido")
                {
                    MessageBox.Show(altas(textBox7.Text, textBox2.Text, comboBox2.Text, comboBox3.Text, textBox1.Text, textBox3.Text, textBox4.Text, comboBox1.Text));
                }
                else if (bandera == "Equipo")
                {
                    MessageBox.Show(altas(textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, maskedTextBox1.Text, comboBox1.Text, "", ""));
                }
                else if (bandera == "Jugador")
                {
                    MessageBox.Show(altas(textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, comboBox1.Text));
                }
                else if (bandera == "Liga")
                {
                    MessageBox.Show(altas(textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, "", "", ""));
                }
                else
                {
                    MessageBox.Show("Ingrese una categoria");
                }
            }
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            Conectar.conexion();
            if (bandera == "Partido" || modif == true)
            {
                this.Text = "Agregar " + bandera;
                SqlCommand c = new SqlCommand("Select nombre from liga", conexion);

                SqlDataReader read = c.ExecuteReader();

                while (read.Read())
                {
                    comboBox1.Items.Add(read.GetString(0));
                    comboBox1.DisplayMember = "nombre";
                }
                read.Close();
                conexion.Close();
            }
            else if (bandera == "Equipo" || modif == true)
            {
                this.BackgroundImage = global ::WindowsFormsApplication1.Properties.Resources.dallas_cowboys;
                this.Text = "Agregar " + bandera;
                SqlCommand c = new SqlCommand("Select nombre from liga", conexion);
                SqlDataReader read = c.ExecuteReader();

                while (read.Read())
                {
                    comboBox1.Items.Add(read.GetString(0));
                    comboBox1.DisplayMember = "nombre";
                }
                read.Close();
            }
            else if (bandera == "Jugador" || modif == true)
            {
                this.BackgroundImage = global :: WindowsFormsApplication1.Properties.Resources.imagen;
                this.Text = "Agregar " + bandera;
                SqlCommand c = new SqlCommand("Select nombre from equipo", conexion);
                SqlDataReader read = c.ExecuteReader();

                while (read.Read())
                {
                    comboBox1.Items.Add(read.GetString(0));
                    comboBox1.DisplayMember = "nombre";
                }
                read.Close();
            }
            else if (bandera == "Liga" || modif == true)
            {
                this.BackgroundImage = global :: WindowsFormsApplication1.Properties.Resources.mlb_logo_wide;
                this.Text = "Agregar " + bandera;
                comboBox1.Items.Add("Futbol");
                comboBox1.Items.Add("Beisbol");
                comboBox1.Items.Add("Futbol americano");
                comboBox1.Items.Add("Basquetbol");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            conexion.Close();
            mostrar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            if (bandera == "Partido")
            {
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if (comboBox1.SelectedIndex == i)
                    {
                        SqlCommand eq = new SqlCommand(string.Format("Select nombre from equipo where liga = '{0}'", comboBox1.SelectedItem), conexion);

                        SqlDataReader reader = eq.ExecuteReader();

                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader.GetValue(0));
                            comboBox2.DisplayMember = "nombre";
                            comboBox3.Items.Add(reader.GetValue(0));
                            comboBox3.DisplayMember = "nombre";
                        }
                        reader.Close();
                    }
                }
            }
            conexion.Close();
        }
        #endregion

        #region actividades BD
        public void mostrar()
        {
            if (bandera == "Partido")
            {              
                label1.Text = "Liga";
                label2.Text = "Local";
                label3.Text = "Visitante";
                label4.Text = "Estadio";
                label5.Text = "Asistentes";
                label6.Text = "Albitro";
                label7.Text = "Marcador";

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;

                textBox1.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = true;
                maskedTextBox1.Visible = false;

                comboBox1.Location = new Point(171, 22);
                comboBox2.Location = new Point(171, 61);
                comboBox3.Location = new Point(171, 101);
                textBox1.Location = new Point(171, 143);
                textBox2.Location = new Point(171, 187);
                textBox3.Location = new Point(171, 233);
                textBox4.Location = new Point(171, 275);

                textBox1.TabIndex = 4;
                textBox2.TabIndex = 5;
                textBox3.TabIndex = 6;
                textBox4.TabIndex = 7;
                comboBox1.TabIndex = 1;
                comboBox2.TabIndex = 2;
                comboBox3.TabIndex = 3;
                textBox7.TabIndex = 8;
                cmdaltas.TabIndex = 9;
                cmdbajas.TabIndex = 11;
            }
            else if (bandera == "Equipo")
            {
                label1.Text = "Nombre del equipo";
                label2.Text = "Numero de plantilla";
                label3.Text = "Tecnico";
                label4.Text = "Fecha de creacion";
                label5.Text = "Liga";
                label6.Text = "";
                label7.Text = "";

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = true;

                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                maskedTextBox1.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = true;

                textBox1.Location = new Point(171, 22);
                textBox2.Location = new Point(171, 61);
                textBox3.Location = new Point(171, 101);
                maskedTextBox1.Location = new Point(171, 143);
                comboBox1.Location = new Point(171, 187);

                comboBox1.TabIndex = 5;
                textBox1.TabIndex = 1;
                textBox2.TabIndex = 2;
                textBox3.TabIndex = 3;
                maskedTextBox1.TabIndex = 4;
                textBox7.TabIndex = 6;
                cmdaltas.TabIndex = 7;
                cmdbajas.TabIndex = 9;
            }
            else if (bandera == "Jugador")
            {
                label1.Text = "Nombre";
                label2.Text = "Apellido";
                label3.Text = "Edad";
                label4.Text = "Altura";
                label5.Text = "Peso";
                label6.Text = "Posicion";
                label7.Text = "Equipo";

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;

                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                maskedTextBox1.Visible = false;

                textBox1.Location = new Point(171, 22);
                textBox2.Location = new Point(171, 61);
                textBox3.Location = new Point(171, 101);
                textBox4.Location = new Point(171, 143);
                textBox5.Location = new Point(171, 187);
                textBox6.Location = new Point(171, 233);
                comboBox1.Location = new Point(171, 275);

                textBox1.TabIndex = 1;
                textBox2.TabIndex = 2;
                textBox3.TabIndex = 3;
                textBox4.TabIndex = 4;
                textBox5.TabIndex = 5;
                textBox6.TabIndex = 6;
                comboBox1.TabIndex = 7;
                textBox7.TabIndex = 8;
                cmdaltas.TabIndex = 9;
                cmdbajas.TabIndex = 11;
            }
            else if (bandera == "Liga")
            {
                label1.Text = "Nombre";
                label2.Text = "Partidos a disputar";
                label3.Text = "Numero de equipos";
                label4.Text = "Deporte";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = true;

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                comboBox1.Visible = true;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                maskedTextBox1.Visible = false;
                textBox7.Visible = true;

                textBox1.Location = new Point(171, 22);
                textBox2.Location = new Point(171, 61);
                textBox3.Location = new Point(171, 101);
                comboBox1.Location = new Point(171, 143);

                comboBox1.TabIndex = 4;
                textBox1.TabIndex = 1;
                textBox2.TabIndex = 2;
                textBox3.TabIndex = 3;
                textBox7.TabIndex = 5;
                cmdaltas.TabIndex = 6;
                cmdbajas.TabIndex = 8;
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        public string altas(string a, string b, string c, string d, string e, string f, string g, string h)
        {
            conexion.Open();
            string arg = "Se encontro un elemento con el mismo id agregue otro para que pueda ser agregador su " + bandera.ToString();
            recorrido(a);

            if (a == "")
            {
                arg = "Agregue id para que sea guardada su " + bandera;
            }
            else if (textBox7.Text != x)
            {
                try
                {
                    if (bandera == "Partido")
                    {
                        SqlCommand alta = new SqlCommand("Insert into partido(id_partido, asistentes, e_local, e_visitante, estadio, arbitro, marcador, liga) values(" + a + ", '" + b + "', '" + c + "',  '" + d + "', '" + e + "', '" + f + "', '" + g + "', '" + h + "')", conexion);
                        alta.ExecuteNonQuery();
                        arg = bandera + " guardada";
                    }
                    else if (bandera == "Equipo")
                    {
                        SqlCommand alta = new SqlCommand("Insert into equipo(id_equipo, nombre, num_jugadores, tecnico, fecha_creacion, liga) values(" + a + ", '" + b + "', '" + c + "',  '" + d + "', '" + e + "', '" + f + "')", conexion);
                        alta.ExecuteNonQuery();
                        arg = bandera + " guardada";
                    }
                    else if (bandera == "Jugador")
                    {
                        SqlCommand alta = new SqlCommand("Insert into jugador(id_jugador, nombre, apellido, edad, altura, peso, posicion, equipo) values(" + a + ", '" + b + "', '" + c + "',  '" + d + "', '" + e + "', '" + f + "', '" + g + "', '" + h + "')", conexion);
                        alta.ExecuteNonQuery();
                        arg = bandera + " guardada";
                    }
                    else if (bandera == "Liga")
                    {
                        SqlCommand alta = new SqlCommand("Insert into liga(id_liga, nombre, partidos, num_equipos, deporte) values(" + a + ", '" + b + "', '" + c + "',  '" + d + "', '" + e + "')", conexion);
                        alta.ExecuteNonQuery();
                        arg = bandera + " guardada";
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return arg;
            conexion.Close();
        }

        public string modificaciones(string a, string b, string c, string d, string e, string f, string g, string h)
        {
            conexion.Open();
            int retorno = 0;
            string arg;
            recorrido(textBox7.Text);
            
            if (textBox7.Text == "" || textBox7.Text != x)
            {
                arg = "Ingrese id valido para poder modificar " + bandera.ToString(); ;
            }
            else
            {
                try
                {
                    if (bandera == "Partido")
                    {
                        SqlCommand modificar = new SqlCommand(string.Format("Update partido set asistencia = '{0}', e_local = '{1}', e_visitante = '{2}', estadio = '{3}', albitro = '{4}', marcador = '{5}', liga = {6} where id_partido = '{7}'", b, c, d, e, f, g, h, a), conexion);
                        retorno = modificar.ExecuteNonQuery();
                    }
                    else if (bandera == "Equipo")
                    {
                        this.BackgroundImage = global ::WindowsFormsApplication1.Properties.Resources.dallas_cowboys;
                        SqlCommand modificar = new SqlCommand(string.Format("Update equipo set nombre = '{0}', num_jugadores = '{1}', tecnico = '{2}', fecha_creacion = '{3}', liga = '{4}' where id_equipo = '{5}'", b, c, d, e, f, a), conexion);
                        retorno = modificar.ExecuteNonQuery();
                    }
                    else if (bandera == "Jugador")
                    {
                        this.BackgroundImage = global :: WindowsFormsApplication1.Properties.Resources.imagen;
                        SqlCommand modificar = new SqlCommand(string.Format("Update jugador set nombre = '{0}', apellido = '{1}', edad = '{2}', altura = '{3}', peso = '{4}', posicion = '{5}', equipo = '{6}' where id_jugador = '{7}'", b, c, d, e, f, g, h, a), conexion);
                        retorno = modificar.ExecuteNonQuery();
                    }
                    else if (bandera == "Liga")
                    {
                        this.BackgroundImage = global :: WindowsFormsApplication1.Properties.Resources.mlb_logo_wide;
                        SqlCommand modificar = new SqlCommand(string.Format("Update liga set nombre = '{0}', partidos = '{1}', num_equipos = '{2}', deporte = '{3}'where id_liga = '{4}'", b, c, d, e, a), conexion);
                        retorno = modificar.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("ERROR");
                }
                arg = bandera + " modificada";
            }
            return arg;
            conexion.Close();
        }

        public void recorrido(string a)
        {
            if(bandera == "Partido")
            {
                SqlCommand consulta = new SqlCommand(string.Format("Select id_partido from partido where id_partido like '{0}' ", a), conexion);

                SqlDataReader Read = consulta.ExecuteReader();

                while (Read.Read())
                {
                    x = Read.GetValue(0).ToString();
                }
                Read.Close();
            }
            else if(bandera == "Equipo")
            {
                SqlCommand consulta = new SqlCommand(string.Format("Select id_equipo from equipo where id_equipo like '{0}' ", a), conexion);

                SqlDataReader Read = consulta.ExecuteReader();

                while (Read.Read())
                {
                    x = Read.GetValue(0).ToString();
                }
                Read.Close();
            }
            else if (bandera == "Jugador")
            {
                SqlCommand consulta = new SqlCommand(string.Format("Select id_jugador from jugador where id_jugador like '{0}' ", a), conexion);

                SqlDataReader Read = consulta.ExecuteReader();

                while (Read.Read())
                {
                    x = Read.GetValue(0).ToString();
                }
                Read.Close();
            }
            else if (bandera == "Liga")
            {
                SqlCommand consulta = new SqlCommand(string.Format("Select id_liga from liga where id_liga like '{0}' ", a), conexion);

                SqlDataReader Read = consulta.ExecuteReader();

                while (Read.Read())
                {
                    x = Read.GetValue(0).ToString();
                }
                Read.Close();
            }
            else 
            {
                MessageBox.Show("ERROR");
            }
        }
        #endregion
    }
}
