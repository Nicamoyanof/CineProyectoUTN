using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using CineProyectoUTN.Dominios;
using System.Data;

namespace CineProyectoUTN.Datos.Interfaz
{
    internal interface IDaoSalas
    {

        List<TipoSala> CargarTipoSalas();

        Salas CargarSalaPorId(int id);

    }
}
