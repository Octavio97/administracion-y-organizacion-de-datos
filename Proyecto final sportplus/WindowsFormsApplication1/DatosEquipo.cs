using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class DatosEquipo
    {
        public String id_equipo { get; set; }
        public String nombre { get; set; }
        public String tecnico { get; set; }
        public String num_jugadores { get; set; }
        public String fecha_creacion { get; set; }
        public String liga { get; set; }

        public void Equipo(String id_equipo, String nombre, String tecnico, String num_jugadores, String fecha_creacion, String liga)
        {
            this.id_equipo = id_equipo;
            this.nombre = nombre;
            this.tecnico = tecnico;
            this.num_jugadores = num_jugadores;
            this.fecha_creacion = fecha_creacion;
            this.liga = liga;
        }
    }
}
