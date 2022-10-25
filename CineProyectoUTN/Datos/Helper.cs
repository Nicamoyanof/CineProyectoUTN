using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CineProyectoUTN.Datos
{
    internal class Helper
    {
        SqlConnection conexion = new SqlConnection(Properties.Resources.StringConex);
        SqlCommand comando = new SqlCommand();
        public DataTable consultaSql(string ConsultaSql)
        {
            try
            {
                conexion.Open();
                DataTable tabla = new DataTable();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = ConsultaSql;
                tabla.Load(comando.ExecuteReader());
                conexion.Close();
                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
    }

}
