using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class DatosLiga
    {
        public String id_liga {get; set;}
        public String nombre { get; set; } 
        public String partidos { get; set; }
        public String num_equipos { get; set; }
        public String deporte { get; set; } 

        public void Liga(String id_liga, String nombre ,String partidos, String num_equipos, String deporte)
        {
            this.id_liga = id_liga;
            this.nombre = nombre;
            this.partidos = partidos;
            this.num_equipos = num_equipos;
            this.deporte = deporte;
        }  
    }
}
