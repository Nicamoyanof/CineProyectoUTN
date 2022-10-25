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
    public partial class FrmReservas : Form
    {
        Helper helper;
        public FrmReservas()
        {
            InitializeComponent();
            helper = new Helper();
        }

        private void porGeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReservaPorGenero frmReservaPorGenero = new FrmReservaPorGenero();
            frmReservaPorGenero.Show();
        }

        private void FrmReservas_Load(object sender, EventArgs e)
        {
            cargarCbo(cboFuncion ,"SELECT * FROM Funciones", "horario", "id_funcion");
            cargarCbo(cboCliente, "SELECT * FROM Clientes", "apellido", "id_cliente");
            cargarCbo(cboFomaPago, "SELECT * FROM Tipos_Pagos", "nombre_tipo_pago", "id_tipo_pago");
            cargarReservas();
        }

        private void cargarReservas()
        {
            DataTable dt = helper.consultaSql("SELECT * FROM Reservas");

            foreach (DataRow dr in dt.Rows)
            {

            }

            dgvResetcas.Rows.Add();
        }

        private void cargarCbo(ComboBox cbo, string select, string display, string value)
        {
            cbo.DataSource = helper.consultaSql(select);
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }

           

    }
}
