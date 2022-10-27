using CineProyectoUTN.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineProyectoUTN.Formularios
{
    public partial class FrmCantidadSocios : Form
    {
        private Helper oDatos;
        public FrmCantidadSocios()
        {
            InitializeComponent();
            oDatos = new Helper();
        }

        private void FrmCantidadSocios_Load(object sender, EventArgs e)
        {
            DataTable tabla = oDatos.ConsultaSQLSP("pa_socios_por_provincia", null);
            dataGridView1.DataSource = tabla;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
