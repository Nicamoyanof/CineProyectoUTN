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
    public partial class FrmGastoPromedioxCliente : Form
    {
        Helper helper;
        public FrmGastoPromedioxCliente()
        {
            InitializeComponent();
            helper = new Helper();  
        }

        private void FrmGastoPromedioxCliente_Load(object sender, EventArgs e)
        {
            DataTable tabla = helper.ConsultaSQLSP("Gasto_promedio_clientes", null);
            dgvGastoPromedioxCliente.DataSource = tabla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
