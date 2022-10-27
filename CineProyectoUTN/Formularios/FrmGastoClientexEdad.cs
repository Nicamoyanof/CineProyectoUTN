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

namespace CineProyectoUTN.Formularios
{
    public partial class FrmGastoClientexEdad : Form
    {
        Helper helper;
        public FrmGastoClientexEdad()
        {
            InitializeComponent();
            helper = new Helper();
        }

        private void FrmGastoClientexEdad_Load(object sender, EventArgs e)
        {
            DataTable tabla = helper.ConsultaSQLSP("Mas_Gastaron_Clientes_mas_menos_35_anios", null);
            dgvGastoClientexEdad.DataSource = tabla;
        }

        private void lblConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
