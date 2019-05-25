using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class DatosJugador
    {
        public String id_jugador { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String posicion { get; set; }
        public String edad { get; set; }
        public String altura { get; set; }
        public String peso { get; set; }
        public String equipo { get; set; }

        public void Jugador(String id_jugador, String nombre, String apellido, String posicion, String edad, String altura, String peso, String equipo)
        {
            this.id_jugador = id_jugador;
            this.nombre = nombre;
            this.apellido = apellido;
            this.posicion = posicion;
            this.edad = edad;
            this.altura = altura;
            this.peso = peso;
            this.equipo = equipo;
        }
    }
}
