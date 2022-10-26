using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineProyectoUTN.Dominios;
using CineProyectoUTN.Datos;

namespace CineProyectoUTN.Formularios
{
    public partial class FrmRecaudacionPelicula : Form
    {

        Helper helper;

        public FrmRecaudacionPelicula()
        {
            InitializeComponent();
            helper = new Helper();
        }

        private void FrmRecaudacionPelicula_Load(object sender, EventArgs e)
        {
            CargarPeliculasRecaudacion();
        }

        public void CargarPeliculasRecaudacion()
        {
            DataTable table = helper.ConsultaSQLSP("SP_TOTAL_RECAUDADO_POR_PELICULA", null);
            foreach (DataRow dr in table.Rows)
            {
                if (dr["Dinero recaudado"].ToString().Equals(string.Empty))
                {
                    dvgRecaudacion.Rows.Add(dr["Pelicula"].ToString(), dr["Genero"].ToString(), "null");
                }
                else
                {
                    dvgRecaudacion.Rows.Add(dr["Pelicula"].ToString(), dr["Genero"].ToString(), dr["Dinero recaudado"].ToString());
                }
            }
        }

    }
}
