using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
        SoundPlayer bk = new SoundPlayer();
        public string bandera;
        public int i = 0;
        public bool tag;

        #region metodos forma
        public Menu()
        {
            InitializeComponent();
            toolTip1.SetToolTip(cmdfutbol, "Jugador");
            toolTip1.SetToolTip(cmdamericano, "Partido");
            toolTip1.SetToolTip(cmdbase, "Liga");
            toolTip1.SetToolTip(cmdbasket, "Equipo");
            toolTip1.SetToolTip(cmdMenu, "Menu");
            toolTip1.SetToolTip(cmdSalir, "Salir");
        }

        private void cmdbase_Click(object sender, EventArgs e)
        {
            bandera = "Liga";
            Datos d = new Datos();
            d.bandera = bandera;
            d.StartPosition = this.StartPosition;
            d.Show();
            this.Hide();
        }

        private void cmdfutbol_Click(object sender, EventArgs e)
        {
            bandera = "Jugador";
            Datos d = new Datos();
            d.bandera = bandera;
            d.StartPosition = this.StartPosition;
            d.Show();
            this.Hide();

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdbasket_Click(object sender, EventArgs e)
        {
            bandera = "Equipo";
            Datos d = new Datos();
            d.bandera = bandera;
            d.StartPosition = this.StartPosition;
            d.Show();
            this.Hide();
        }

        private void cmdamericano_Click(object sender, EventArgs e)
        {
            bandera = "Partido";
            Datos d = new Datos();
            d.bandera = bandera;
            d.StartPosition = this.StartPosition;
            d.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (i == 0)
            {
                bk.SoundLocation =  @"E:\administracion y organizacion de datos\Proyecto final sportplus\WindowsFormsApplication1\Resources\Himno de la UEFA Champions League.wav";
                bk.PlayLooping();
                i++;
            }
        }

        private void cmdMenu_Click(object sender, EventArgs e)
        {
            if(tag == false)
            {
                cmdamericano.Visible = true;
                cmdbase.Visible = true;
                cmdbasket.Visible = true;
                cmdfutbol.Visible = true;
                tag = true;
            }
            else if (tag == true)
            {
                cmdamericano.Visible = false;
                cmdbase.Visible = false;
                cmdbasket.Visible = false;
                cmdfutbol.Visible = false;
                tag = false;
            }
        }
        #endregion
    }
}
