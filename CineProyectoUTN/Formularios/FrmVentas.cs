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
    public partial class FrmVentas : Form
    {
        Helper helper;
        public FrmVentas()
        {
            InitializeComponent();
            helper = new Helper();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            cargarCbo(cboFuncion, "SELECT * FROM Funciones", "horario", "id_funcion");
            cargarCbo(cboCliente, "SELECT * FROM Clientes", "apellido", "id_cliente");
            cargarCbo(cboEmpleado, "SELECT * FROM Empleados", "apellido_empleado", "id_empleado");
            cargarCbo(cboFormaPago, "SELECT * FROM Tipos_Pagos", "nombre_tipo_pago", "id_tipo_pago");
            cargarTickets();
        }

        private void cargarCbo(ComboBox cbo, string select, string display, string value)
        {
            cbo.DataSource = helper.consultaSql(select);
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }

        private void cargarTickets()
        {
            DataTable dt = helper.consultaSql("SELECT * FROM Tickets");

            foreach (DataRow dr in dt.Rows)
            {

            }

            dgvTickets.Rows.Add();
        }

        private void filtroPorEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmFiltroporEdad frmFiltroporEdad = new FrmFiltroporEdad();
            //frmFiltroporEdad.Show();
        }
    }
}
