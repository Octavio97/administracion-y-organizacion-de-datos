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
    public partial class Datos : Form
    {

        public string bandera;
        public int i;
        ContextMenuStrip s = new System.Windows.Forms.ContextMenuStrip();
        public string celdanom;
        public bool modif;

        #region metodos forma
        public Datos()
        {
            InitializeComponent();
            toolTip1.SetToolTip(cmdBuscar, "Buscar");
            toolTip1.SetToolTip(cmdaltas, "Agregar");
            toolTip1.SetToolTip(cmdRegresar, "Volver a menu");
        }

        private void cmdRegresar_Click(object sender, EventArgs e)
        {
            i = 1;
            Menu m = new Menu();
            m.i = i;
            m.Show();
            this.Hide();
        }

        private void cmdaltas_Click(object sender, EventArgs e)
        {
            Agregar a = new Agregar();
            a.bandera = bandera;
            a.Text = bandera.ToString();;
            modif = false;
            a.modif = modif;
            a.Show();
            this.Hide();      
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (bandera == "Liga" && textBox1.Text != "")
            {
                dataGridView1.ClearSelection();
                dataGridView1.DataSource = consultaLiga(textBox1.Text);
            }
            else if (bandera == "Jugador" && textBox1.Text != "")
            {
                dataGridView1.ClearSelection();
                dataGridView1.DataSource = consultaJugador(textBox1.Text);
            }
            else if (bandera == "Partido" && textBox1.Text != "")
            {
                dataGridView1.ClearSelection();
                dataGridView1.DataSource = consultaPartido(textBox1.Text);
            }
            else if (bandera == "Equipo" && textBox1.Text != "")
            {
                dataGridView1.ClearSelection();
                dataGridView1.DataSource = consultaEquipo(textBox1.Text);
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Datos_Load(object sender, EventArgs e)
        {
            this.Text = "Información " + bandera.ToString();
            s.Items.Add("Eliminar").Name = "Eliminar";
            s.Items.Add("Modificar").Name = "Modificar";

            dataGridView1.MouseClick += dataGridView1_MouseClick;
        }

        void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                s.Show(dataGridView1,new Point(e.X,e.Y));
                int posicion = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                s.ItemClicked += s_ItemClicked;      
            }
        }

        void s_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "Eliminar":
                    s.Hide();
                    MessageBox.Show(bajas(dataGridView1.CurrentCell.Value.ToString()));                 
                    break;

                case "Modificar":
                    s.Hide();
                   // Agregar a = new Agregar();
                    modi();
                    this.Hide();
                    break;
            }
        }

        public void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            celdanom = dataGridView1.Columns[e.ColumnIndex].Name;
        }
        #endregion
        
        #region metodos BD
        public static List<DatosLiga> consultaLiga(string a)
        {
            List<DatosLiga> liga = new List<DatosLiga>();
            using (SqlConnection conexion = Conectar.conexion())
            {
                SqlCommand consulta1 = new SqlCommand(string.Format("Select * from liga as p where p.id_liga like '%{0}%' or p.nombre like '%{1}%' or p.partidos like '%{2}%' or p.num_equipos like '%{3}%' or p.deporte like '%{4}%' ", a, a, a, a, a), conexion);

                SqlDataReader Read = consulta1.ExecuteReader();

                while (Read.Read())
                {
                    DatosLiga dato = new DatosLiga();
                    dato.id_liga = Read.GetString(0);
                    dato.nombre = Read.GetString(1);
                    dato.partidos = Read.GetString(2);
                    dato.num_equipos = Read.GetString(3);
                    dato.deporte = Read.GetString(4);
                    liga.Add(dato);
                }
                conexion.Close();
                return liga;
            }
        }

        public static List<DatosJugador> consultaJugador(string a)
        {
            List<DatosJugador> jugador = new List<DatosJugador>();
            using (SqlConnection conexion = Conectar.conexion())
            {
                SqlCommand consulta1 = new SqlCommand(string.Format("Select * from jugador as p where p.id_jugador like '%{0}%' or p.nombre like '%{1}%' or p.apellido like '%{2}%' or p.posicion like '%{3}%' or p.edad like '%{4}%' or p.altura like '%{5}%'or p.peso like '%{6}%' or p.equipo like '%{7}%' ", a, a, a, a, a, a, a, a), conexion);

                SqlDataReader Read = consulta1.ExecuteReader();

                while (Read.Read())
                {
                    DatosJugador dato = new DatosJugador();
                    dato.id_jugador = Read.GetString(0);
                    dato.nombre = Read.GetString(1);
                    dato.apellido = Read.GetString(2);
                    dato.posicion = Read.GetString(3);
                    dato.edad = Read.GetString(4);
                    dato.altura = Read.GetString(5);
                    dato.peso = Read.GetString(6);
                    dato.equipo = Read.GetString(7);
                    jugador.Add(dato);
                }
                conexion.Close();
                return jugador;
            }
        }

        public static List<DatosPartido> consultaPartido(string a)
        {
            List<DatosPartido> partido = new List<DatosPartido>();
            using (SqlConnection conexion = Conectar.conexion())
            {
                SqlCommand consulta = new SqlCommand(string.Format("Select * from partido as p where p.id_partido like '{0}' or p.asistentes like '%{1}%' or p.e_local like '%{2}%' or p.e_visitante like '%{3}%' or p.estadio like '%{4}%' or p.arbitro like '%{5}%'or p.marcador like '%{6}%' or p.liga like '%{7}%' ", a, a, a, a, a, a, a, a), conexion);

                SqlDataReader Read = consulta.ExecuteReader();

                while (Read.Read())
                {
                    DatosPartido dato = new DatosPartido();
                    dato.id_partido = Read.GetString(0);
                    dato.asistentes = Read.GetString(2);
                    dato.e_local = Read.GetString(3);
                    dato.e_visitante = Read.GetString(4);
                    dato.estadio = Read.GetString(5);
                    dato.arbitro = Read.GetString(1);
                    dato.marcador = Read.GetString(6);
                    dato.liga = Read.GetString(7);
                    partido.Add(dato);
                }
                conexion.Close();
                return partido;
            }
        }

        public static List<DatosEquipo> consultaEquipo(string a)
        {
            List<DatosEquipo> equipo = new List<DatosEquipo>();
            using (SqlConnection conexion = Conectar.conexion())
            {
                SqlCommand consulta = new SqlCommand(string.Format("Select * from equipo as p where p.id_equipo like '%{0}%' or p.nombre like '%{1}%' or p.tecnico like '%{2}%' or p.num_jugadores like '%{3}%' or p.fecha_creacion like '%{4}%' or p.liga like '%{5}%' ", a, a, a, a, a, a), conexion);

                SqlDataReader Read = consulta.ExecuteReader();

                while (Read.Read())
                {
                    DatosEquipo dato = new DatosEquipo();
                    dato.id_equipo = Read.GetString(0);
                    dato.nombre = Read.GetString(1);
                    dato.tecnico = Read.GetString(2);
                    dato.num_jugadores = Read.GetString(3);                    
                    dato.fecha_creacion = Read.GetString(4);
                    dato.liga = Read.GetString(5);
                    equipo.Add(dato);
                }
                conexion.Close();
                return equipo;
            }
        }
        
        public string bajas(string a)
        {
            string arg = "Ingrese id para eliminar " + bandera.ToString();
            SqlConnection conectar = new SqlConnection();
            conectar = Conectar.conexion();

            if (textBox1.Text != "")
            {
                try
                {
                    if (bandera == "Liga")
                    {
                        string baja = "DELETE FROM liga WHERE id_liga = @Liga or nombre = @Liga or partidos = @Liga or num_equipos = @Liga or deporte = @Liga";

                        SqlCommand cmdins = new SqlCommand(baja, conectar);
                        cmdins.Parameters.AddWithValue("Liga", a);
                        cmdins.ExecuteNonQuery();

                        cmdins.Dispose();
                        cmdins = null;
                        arg = "Liga eliminada";
                       
                    }
                    else if (bandera == "Jugador")
                    {
                        string baja = "DELETE FROM jugador WHERE id_jugador = @Jugador or nombre = @Jugador or apellido = @Jugador or posicion = @Jugador or edad = @Jugador or altura  = @Jugador or peso  = @Jugador or equipo = @Jugador";

                        SqlCommand cmdins = new SqlCommand(baja, conectar);
                        cmdins.Parameters.AddWithValue("Jugador", a);
                        cmdins.ExecuteNonQuery();

                        cmdins.Dispose();
                        cmdins = null;
                        arg = "Jugador eliminada";
                        
                    }
                    else if (bandera == "Equipo")
                    {
                        string baja = "DELETE FROM equipo WHERE id_equipo = @Equipo or nombre = @Equipo or num_jugadores = @Equipo or tecnico = @Equipo or fecha_creacion = @Equipo or liga = @Equipo";

                        SqlCommand cmdins = new SqlCommand(baja, conectar);
                        cmdins.Parameters.AddWithValue("Equipo", a);
                        cmdins.ExecuteNonQuery();

                        cmdins.Dispose();
                        cmdins = null;
                        arg = "Equipo eliminado";
                    }
                    else if (bandera == "Partido")
                    {
                        string baja = "DELETE FROM partido WHERE id_partido = @Partido or arbitro = @Partido or asistentes = @Partido or e_local = @Partido or e_visitante = @Partido or estadio  = @Partido or marcador = @Partido or liga = @Partido";

                        SqlCommand cmdins = new SqlCommand(baja, conectar);
                        cmdins.Parameters.AddWithValue("Partido", a);
                        cmdins.ExecuteNonQuery();

                        cmdins.Dispose();
                        cmdins = null;
                        arg = "Partido eliminada";
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
            }
            conectar.Close();
            return arg;
        }

        public void modi()
        {
            Conectar.conexion();
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            Agregar fag = new Agregar();

            if(bandera == "Liga")
            {
                fag.textBox7.Enabled = false;
                string val = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["id_liga"].Value.ToString();
                SqlCommand recorrer = new SqlCommand(string.Format("Select * from liga where id_liga = '{0}'", val), Conectar.conexion());
                SqlDataReader leer = recorrer.ExecuteReader();

                while (leer.Read())
                {
                    fag.textBox7.Text = leer.GetString(0);
                    fag.textBox1.Text = leer.GetString(1);
                    fag.textBox2.Text = leer.GetString(2);
                    fag.textBox3.Text = leer.GetString(3);
                    fag.comboBox1.Text = leer.GetString(4);
                }
                leer.Close();
                fag.bandera = bandera;
                modif = true;
                fag.modif = modif;
                fag.BackgroundImage = global :: WindowsFormsApplication1.Properties.Resources.mlb_logo_wide; 
                fag.Text = bandera.ToString();
                fag.Show();
                this.Hide();
            }
            else if(bandera == "Jugador")
            {
                fag.textBox7.Enabled = false;
                string val = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["id_jugador"].Value.ToString();
                SqlCommand recorrer = new SqlCommand(string.Format("Select * from jugador where id_jugador = '{0}'", val), Conectar.conexion());
                SqlDataReader leer = recorrer.ExecuteReader();

                while (leer.Read())
                {
                    fag.textBox7.Text = leer.GetString(0);
                    fag.textBox1.Text = leer.GetString(1);
                    fag.textBox2.Text = leer.GetString(2);
                    fag.textBox6.Text = leer.GetString(3);
                    fag.textBox3.Text = leer.GetString(4);
                    fag.textBox4.Text = leer.GetString(5);
                    fag.textBox5.Text = leer.GetString(6);
                    fag.comboBox1.Text = leer.GetString(7);
                }
                leer.Close();
                fag.bandera = bandera;
                modif = true;
                fag.modif = modif;
                fag.BackgroundImage = global :: WindowsFormsApplication1.Properties.Resources.imagen;
                fag.Text = bandera.ToString(); ;
                fag.Show();
                this.Hide();
            }
            else if (bandera == "Partido")
            {
                fag.textBox7.Enabled = false;
                string val = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["id_partido"].Value.ToString();
                SqlCommand recorrer = new SqlCommand(string.Format("Select * from partido where id_partido = '{0}'", val), Conectar.conexion());
                SqlDataReader leer = recorrer.ExecuteReader();

                while (leer.Read())
                {
                    fag.textBox7.Text = leer.GetString(0);
                    fag.textBox3.Text = leer.GetString(1);
                    fag.textBox2.Text = leer.GetString(2);
                    fag.comboBox2.Text = leer.GetString(3);
                    fag.comboBox3.Text = leer.GetString(4);
                    fag.textBox1.Text = leer.GetString(5);
                    fag.textBox4.Text = leer.GetString(6);
                    fag.comboBox1.Text = leer.GetString(7);
                }
                leer.Close();
                fag.bandera = bandera;
                modif = true;
                fag.modif = modif;
                fag.Text = bandera.ToString(); ;
                fag.Show();
                this.Hide();
            }
            else if (bandera == "Equipo")
            {
                fag.textBox7.Enabled = false;
                string val = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["id_equipo"].Value.ToString();
                SqlCommand recorrer = new SqlCommand(string.Format("Select * from equipo where id_equipo = '{0}'", val), Conectar.conexion());
                SqlDataReader leer = recorrer.ExecuteReader();

                while (leer.Read())
                {
                    fag.textBox7.Text = leer.GetString(0);
                    fag.textBox1.Text = leer.GetString(1);
                    fag.textBox3.Text = leer.GetString(2);
                    fag.textBox2.Text = leer.GetString(3);
                    fag.maskedTextBox1.Text = leer.GetString(4);
                    fag.comboBox1.Text = leer.GetString(5);
                }
                leer.Close();
                fag.bandera = bandera;
                modif = true;
                fag.modif = modif;
                fag.BackgroundImage = global ::WindowsFormsApplication1.Properties.Resources.dallas_cowboys;
                fag.Text = bandera.ToString(); ;
                fag.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            Conectar.conexion().Close();
        }
        #endregion
        
    }
}
