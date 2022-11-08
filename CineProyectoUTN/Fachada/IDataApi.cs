using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineProyectoUTN.Dominios;

namespace CineProyectoUTN.Fachada
{
    internal interface IDataApi
    {
        public List<Peliculas> ObtenerPeliculas();

        public List<GeneroPelicula> ObtenerGeneros();
        public List<EdadesPermitidas> ObtenerEdadesPermitidas();

    }
}
