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

        public DataTable ConsultaSQLSP(string spNombre, List<Parametro> values)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            SqlCommand cmd = new SqlCommand(spNombre, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (Parametro oParametro in values)
                {
                    cmd.Parameters.AddWithValue(oParametro.Clave, oParametro.Valor);
                }
            }
            tabla.Load(cmd.ExecuteReader());
            conexion.Close();

            return tabla;
        }

        public DataTable consultaSql(string ConsultaSql)
        {
            try
            {
                conexion.Open();
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand();
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
