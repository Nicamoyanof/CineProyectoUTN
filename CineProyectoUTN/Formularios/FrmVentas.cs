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
            habilitar(true);
        }

        private void habilitar(bool v)
        {
            cboCliente.Enabled = !v;
            cboEmpleado.Enabled = !v;
            cboFormaPago.Enabled = !v;
            cboFuncion.Enabled = !v;
            txtPrecioEntrada.Enabled = !v;
            dtpFechaPago.Enabled = !v;
            nupTickets.Enabled = !v;

        }

        private void cargarCbo(ComboBox cbo, string select, string display, string value)
        {
            cbo.DataSource = helper.consultaSql(select);
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }

        private void cargarTickets()
        {
            DataTable tabla =
                   helper.consultaSql
                 ("select t.id_ticket 'ID Ticket',c.apellido +' '+ c.nombre 'Cliente',e.apellido_empleado +' '+ e.nombre_empleado 'Empleado', c.fecha_nac 'Fecha de Nacimiento Cliente'," +
                 "p.nombre_pelicula 'Pelicula', f.horario 'Horario-Funcion', socio 'Socio', Nombre_ciudad 'Ciudad' " +
                 "from tickets t join clientes c on c.id_cliente = t.id_cliente join ciudades ciu on c.id_ciudad=ciu.id_ciudad join empleados e on e.id_empleado=t.id_empleado join funciones f on f.id_funcion=t.id_funcion join peliculas p on p.id_pelicula=f.id_pelicula");
            dgvTickets.DataSource = tabla;
        }

        private void filtroPorEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void filtroPorEdadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmGastoClientexEdad frmFiltroporEdad = new FrmGastoClientexEdad();
            frmFiltroporEdad.Show();
        }

        private void gastoPromedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGastoPromedioxCliente frmGastoPromedioxCliente = new FrmGastoPromedioxCliente();
            frmGastoPromedioxCliente.Show();
        }

        private void dgvTickets_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            cboCliente.Text = dgvTickets.CurrentRow.Cells[1].Value.ToString();
            cboEmpleado.Text = dgvTickets.CurrentRow.Cells[2].Value.ToString();
            cboFuncion.Text = dgvTickets.CurrentRow.Cells[5].Value.ToString();
            cboFormaPago.Text = "Tarjeta de Debito";
            txtPrecioEntrada.Text = "1040";
            dtpFechaPago.Value = Convert.ToDateTime(dgvTickets.CurrentRow.Cells[5].Value);

            DataTable dt = helper.consultaSql("SELECT COUNT(*) 'cantidad' FROM DETALLES_TICKETS WHERE id_ticket = " + dgvTickets.CurrentRow.Cells[0].Value.ToString());
            foreach (DataRow dr in dt.Rows)
            {
                nupTickets.Value = int.Parse(dr["cantidad"].ToString());
            }

            txtPrecioFinal.Text = (nupTickets.Value * int.Parse(txtPrecioEntrada.Text)).ToString();

        }
    }
}

