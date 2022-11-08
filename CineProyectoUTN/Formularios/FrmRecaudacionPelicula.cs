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
using CineProyectoUTN.Fachada.Interfaz;
using CineProyectoUTN.Fachada.Implementacion;

namespace CineProyectoUTN.Formularios
{
    public partial class FrmRecaudacionPelicula : Form
    {
        IPeliculasApi daoPelicula;

        public FrmRecaudacionPelicula()
        {
            InitializeComponent();
            daoPelicula = new PeliculasApiImp();
        }

        private void FrmRecaudacionPelicula_Load(object sender, EventArgs e)
        {
            CargarPeliculasRecaudacion();
        }

        public void CargarPeliculasRecaudacion()
        {
            DataTable table = daoPelicula.CargarPeliculasRecaudacion();
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

        private void dvgRecaudacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
