using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineProyectoUTN.Dominios;
using CineProyectoUTN.Datos.Implementacion;
using CineProyectoUTN.Datos.Interfaz;
using CineProyectoUTN.Fachada.Interfaz;
using System.Data;

namespace CineProyectoUTN.Fachada.Implementacion
{
    internal class PeliculasApiImp : IPeliculasApi
    {

        private IDaoPeliculas daoPelicula;
        private IDaoSalas daoSala;
        private IDaoFunciones daoFunciones;

        public PeliculasApiImp()
        {
            daoPelicula = new PeliculasDao();
        }

        public List<Funciones> CargarFunciones()
        {
            return daoFunciones.CargarFunciones();
        }

        public Peliculas CargarPeliculaPorId(int id)
        {
            return daoPelicula.CargarPeliculaPorId(id);
        }

        public DataTable CargarPeliculasRecaudacion()
        {
            return daoPelicula.CargarPeliculasRecaudacion();
        }

        public Salas CargarSalaPorId(int id)
        {
            return daoSala.CargarSalaPorId(id);
        }

        public List<TipoSala> CargarTipoSalas()
        {
            return daoSala.CargarTipoSalas();
        }

        public List<EdadesPermitidas> ObtenerEdadesPermitidas()
        {
            return daoPelicula.ObtenerEdadesPermitidas();
        }

        public List<GeneroPelicula> ObtenerGeneros()
        {
            return daoPelicula.ObtenerGeneros();
        }

        public List<Peliculas> ObtenerPeliculas()
        {
            return daoPelicula.ObtenerPeliculas();
        }



    }
}
