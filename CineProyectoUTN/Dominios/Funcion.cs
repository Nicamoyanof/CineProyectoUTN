using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineProyectoUTN.Dominios
{
    public class Funciones
    {

        public Funciones(Peliculas pelicula, Salas sala, DateTime horario)
        {
            Pelicula = pelicula;
            Sala = sala;
            Horario = horario;
        }
        public Funciones()
        {
            Pelicula = new Peliculas();
            Sala = new Salas();
            Horario = new DateTime();
        }

        public Peliculas Pelicula { get; set; }
        public Salas Sala { get; set; }
        public DateTime Horario { get; set; }


    }
}
