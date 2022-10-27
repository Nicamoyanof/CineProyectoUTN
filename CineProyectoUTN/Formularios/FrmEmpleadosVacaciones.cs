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
    public partial class FrmEmpleadosVacaciones : Form
    {
        private Helper oDatos;
        public FrmEmpleadosVacaciones()
        {
            InitializeComponent();
            oDatos = new Helper();
        }

        private void FrmEmpleadosVacaciones_Load(object sender, EventArgs e)
        {
            DataTable tabla = oDatos.ConsultaSQLSP("pa_vacaciones_empleados", null);
            dataGridView1.DataSource = tabla;
        }
    }
}
