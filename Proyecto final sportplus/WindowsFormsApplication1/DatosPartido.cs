using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class DatosPartido
    {
        public String id_partido { get; set; }
        public String arbitro { get; set; }
        public String asistentes { get; set; }
        public String estadio { get; set; }
        public String e_local { get; set; }
        public String e_visitante { get; set; }
        public String marcador { get; set; }
        public String liga { get; set; }

        public void Partido(String id_partido, String arbitro, String asistentes, String estadio, String e_local, String e_visitante, String marcador, String liga)
        {
            this.id_partido = id_partido;
            this.arbitro = arbitro;
            this.asistentes = asistentes;
            this.estadio = estadio;
            this.e_local = e_local;
            this.e_visitante = e_visitante;
            this.marcador = marcador;
            this.liga = liga;
        }
    }
}
