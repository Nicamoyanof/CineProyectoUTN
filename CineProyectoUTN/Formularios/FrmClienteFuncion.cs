using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineProyectoUTN.Datos;
using CineProyectoUTN.Dominios;

namespace CineProyectoUTN.Formularios
{
    public partial class FrmClienteFuncion : Form
    {

        Helper helper;

        public FrmClienteFuncion()
        {
            InitializeComponent();
            helper = new Helper();
        }

        private void FrmClienteFuncion_Load(object sender, EventArgs e)
        {
            CargarClienteFuncion();
        }

        public void CargarClienteFuncion()
        {
            DataTable table = helper.ConsultaSQLSP("SP_CLIENTE_FUNCION", null);
            foreach (DataRow dr in table.Rows)
            {
                dgvClienteFuncion.Rows.Add(dr["Nombre cliente"].ToString(), dr[" pelicula"].ToString(), dr["Cantidad de entradas compradas"].ToString(), dr["Horario funcion"].ToString());
            }
        }

    }
}
