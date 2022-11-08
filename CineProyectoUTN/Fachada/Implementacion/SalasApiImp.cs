using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineProyectoUTN.Dominios;
using CineProyectoUTN.Datos.Implementacion;
using CineProyectoUTN.Datos.Interfaz;
using CineProyectoUTN.Fachada.Interfaz;

namespace CineProyectoUTN.Fachada.Implementacion
{
    internal class SalasApiImp : ISalasApi
    {

        private IDaoSalas daoSala;

        public SalasApiImp()
        {
            daoSala = new SalasDao();
        }


        public Salas CargarSalaPorId(int id)
        {
            return daoSala.CargarSalaPorId(id);
        }

        public List<TipoSala> CargarTipoSalas()
        {
            return daoSala.CargarTipoSalas();
        }

    }
}
