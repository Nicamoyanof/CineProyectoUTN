using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineProyectoUTN.Dominios;
using System.Data;

namespace CineProyectoUTN.Fachada.Interfaz
{
    internal interface IPeliculasApi
    {
        public List<Peliculas> ObtenerPeliculas();

        public List<GeneroPelicula> ObtenerGeneros();
        public List<EdadesPermitidas> ObtenerEdadesPermitidas();

        public Peliculas CargarPeliculaPorId(int id);

        public DataTable CargarPeliculasRecaudacion();

    }
}
