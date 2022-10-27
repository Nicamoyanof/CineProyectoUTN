using CineProyectoUTN.Datos;
using CineProyectoUTN.Dominios;
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
            cargarCbo(cboFuncion, "SELECT * FROM Funciones", "horario", "id_funcion");
            cargarCbo(cboCliente, "SELECT * FROM Clientes", "apellido", "id_cliente");
            cargarReservas();
            habilitar(true);
        }



        private void habilitar(bool v)
        {
            btnAgregar.Enabled = !v;
            btnBorrar.Enabled = !v;
            btnEditar.Enabled = !v;
            btnCancelar.Enabled = v;
            cboFuncion.SelectedIndex = -1;
            cboCliente.SelectedIndex = -1;
            dtpConfirmacion.Value = DateTime.Now;
            dtpReserva.Value = DateTime.Now;
            txtPrecio.Text.Equals(string.Empty);
            txtPrecio.Enabled = !v;
            numCantTicket.Enabled = !v;
        }

        private void cargarReservas()
        {
            DataTable dt = helper.consultaSql("SELECT c.apellido+SPACE(1)+c.nombre Cliente, r.fecha_reserva Fecha, p.nombre_pelicula Pelicula, c.socio Socio\r\nFROM  Reservas r\r\njoin Clientes c on c.id_cliente = r.id_cliente\r\nJoin Funciones f on f.id_funcion = r.id_funcion\r\nJoin Peliculas p on p.id_pelicula = f.id_pelicula");
            dgvReservas.DataSource = dt;
        }
        private void cargarCbo(ComboBox cbo, string select, string display, string value)
        {
            cbo.DataSource = helper.consultaSql(select);
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboCliente.Text = dgvReservas.CurrentRow.Cells[0].Value.ToString();
            dtpReserva.Text = dgvReservas.CurrentRow.Cells[1].Value.ToString();
            cboFuncion.Text = dgvReservas.CurrentRow.Cells[2].Value.ToString();
            dtpConfirmacion.Text = dgvReservas.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = 1000.ToString();
            numCantTicket.Value = 2;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}