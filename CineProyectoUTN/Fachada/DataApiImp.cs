using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineProyectoUTN.Dominios;
using CineProyectoUTN.Datos.Implementacion;
using CineProyectoUTN.Datos.Interfaz;

namespace CineProyectoUTN.Fachada
{
    internal class DataApiImp:IDataApi
    {

        private IDaoPeliculas dao;

        public DataApiImp()
        {
            dao = new PeliculasDao();
        }


        public List<EdadesPermitidas> ObtenerEdadesPermitidas()
        {
            return dao.ObtenerEdadesPermitidas();
        }

        public List<GeneroPelicula> ObtenerGeneros()
        {
            return dao.ObtenerGeneros();
        }

        public List<Peliculas> ObtenerPeliculas()
        {
            return dao.ObtenerPeliculas();
        }



    }
}
