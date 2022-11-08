using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CineProyectoUTN.Dominios;
using CineProyectoUTN.Datos;
using CineProyectoUTN.Datos.Interfaz;
using CineProyectoUTN.Fachada.Interfaz;
using CineProyectoUTN.Fachada.Implementacion;

namespace CineProyectoUTN.Datos.Implementacion
{
    internal class FuncionesDao : IDaoFunciones
    {

        IPeliculasApi dao = new PeliculasApiImp();
        ISalasApi daoSala = new SalasApiImp();

        public List<Funciones> CargarFunciones()
        {
            DataTable table = Helper.ObtenerInstancia().ConsultarSQLScript("SELECT * FROM Funciones WHERE DAY(horario) = 01");

            List<Funciones> lFunciones = new List<Funciones>();

            foreach (DataRow dataRow in table.Rows)
            {
                Funciones funcion = new Funciones();

                funcion.IdFuncion = int.Parse(dataRow["id_funcion"].ToString());
                funcion.Pelicula = dao.CargarPeliculaPorId(int.Parse(dataRow["id_pelicula"].ToString()));
                funcion.Sala = daoSala.CargarSalaPorId(int.Parse(dataRow["id_sala"].ToString()));
                funcion.Horario = Convert.ToDateTime(dataRow["horario"].ToString());
                lFunciones.Add(funcion);

            }

            return lFunciones;

        }
    }
}
