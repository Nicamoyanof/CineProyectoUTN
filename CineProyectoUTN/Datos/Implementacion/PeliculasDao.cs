using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CineProyectoUTN.Dominios;
using CineProyectoUTN.Datos;
using CineProyectoUTN.Datos.Interfaz;

namespace CineProyectoUTN.Datos.Implementacion
{
    internal class PeliculasDao: IDaoPeliculas
    {


        public List<Peliculas> ObtenerPeliculas()
        {
            List<Peliculas> lst = new List<Peliculas>();

            DataTable table = Helper.ObtenerInstancia().ConsultarSQLScript("SELECT * FROM PELICULAS");
            foreach (DataRow dr in table.Rows)
            {
                Peliculas pelicula = new Peliculas();
                pelicula.Descripcion = dr["descripcion_pelicula"].ToString();
                pelicula.Nombre = dr["nombre_pelicula"].ToString();
                pelicula.Genero = ObtenerGeneros()[(Convert.ToInt32(dr["id_genero_pelicula"].ToString())) - 1];
                pelicula.EdadMinima = ObtenerEdadesPermitidas()[(Convert.ToInt32(dr["id_edad_permitida"].ToString())) - 1];
                pelicula.NombrePoster = dr["nombre_imagen"].ToString();

                lst.Add(pelicula);

            }

            return lst;
        }

        public List<GeneroPelicula> ObtenerGeneros()
        {
            List<GeneroPelicula> lst = new List<GeneroPelicula>();

            DataTable table = Helper.ObtenerInstancia().ConsultarSQLScript("SELECT * FROM Generos_peliculas");
            foreach (DataRow dr in table.Rows)
            {
                GeneroPelicula genero = new GeneroPelicula();
                genero.Nombre = dr["nombre_genero"].ToString();
                genero.Descripcion = dr["descripcion_genero"].ToString();

                lst.Add(genero);
            }
            return lst;
        }

        public List<EdadesPermitidas> ObtenerEdadesPermitidas()
        {
            List<EdadesPermitidas> lst = new List<EdadesPermitidas>();

            DataTable table = Helper.ObtenerInstancia().ConsultarSQLScript("SELECT * FROM Edades_permitidas");
            foreach (DataRow dr in table.Rows)
            {
                EdadesPermitidas edades = new EdadesPermitidas();
                edades.Nombre = dr["nombre_edad"].ToString();
                edades.Edad = int.Parse(dr["minimo_edad"].ToString());

                lst.Add(edades);

            }
            return lst;
        }

        public bool Crear(Peliculas oPresupuesto)
        {
            throw new NotImplementedException();
        }

        public bool Actualizar(Peliculas oPresupuesto)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(int nro)
        {
            throw new NotImplementedException();
        }
    }
}
