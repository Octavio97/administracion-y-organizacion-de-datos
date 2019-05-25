using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Conectar
    {
        public static SqlConnection conexion() 
        {
            SqlConnection conectar = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = sportplus; Integrated Security = true");
            try
            {
                conectar.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor " + ex.Message);       
            }
            return conectar;
        }
    }
}
