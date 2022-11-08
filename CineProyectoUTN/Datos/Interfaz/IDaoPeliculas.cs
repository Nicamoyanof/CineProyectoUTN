using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineProyectoUTN.Dominios;
using System.Data;

namespace CineProyectoUTN.Datos.Interfaz
{
    internal interface IDaoPeliculas
    {

        List<Peliculas> ObtenerPeliculas();
        bool Crear(Peliculas oPresupuesto);
        bool Actualizar(Peliculas oPresupuesto);
        bool Borrar(int nro);

        List<GeneroPelicula> ObtenerGeneros();
        List<EdadesPermitidas> ObtenerEdadesPermitidas();

    }
}
