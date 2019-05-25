using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_organizacion_de_archivos
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
            toolTip1.SetToolTip(button1,"Categoria");
            toolTip1.SetToolTip(button2,"Pagina web");
            toolTip1.SetToolTip(button4, "Salir");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmcategoria obj = new frmcategoria();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPagina_web obj = new frmPagina_web();
            obj.Show();
            this.Hide();
        }
    }
}
