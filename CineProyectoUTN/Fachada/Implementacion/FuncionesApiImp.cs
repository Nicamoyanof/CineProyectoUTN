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
    internal class FuncionesApiImp:IFuncionesApi
    {
        private IDaoFunciones daoFunciones;

        public FuncionesApiImp()
        {
            daoFunciones = new FuncionesDao();
        }

        public List<Funciones> CargarFunciones()
        {
            return daoFunciones.CargarFunciones();
        }

       

    }
}
