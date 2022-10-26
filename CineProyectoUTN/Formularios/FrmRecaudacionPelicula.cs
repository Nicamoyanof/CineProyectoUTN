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

        }

        public void CargarPeliculasRecaudacion()
        {
            DataTable table = helper.ConsultaSQLSP("SP_TOTAL_RECAUDADO_POR_PELICULA", null);
            foreach (DataRow dr in table.Rows)
            {

            }
        }

    }
}
