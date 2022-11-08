using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineProyectoUTN.Dominios
{
    public class Peliculas
    {

        public Peliculas(string nombre, EdadesPermitidas edadMinima, GeneroPelicula genero, string descripcion)
        {
            Nombre = nombre;
            EdadMinima = edadMinima;
            Genero = genero;
            Descripcion = descripcion;
        }

        public Peliculas()
        {
            Nombre = "sin nombre";
            EdadMinima = new EdadesPermitidas();
            Genero = new GeneroPelicula();
            Descripcion = "sin descripcion";
        }

        public string Nombre { get; set; }
        public EdadesPermitidas EdadMinima { get; set; }
        public GeneroPelicula Genero { get; set; }
        public string Descripcion { get; set; }

        public string NombrePoster { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
