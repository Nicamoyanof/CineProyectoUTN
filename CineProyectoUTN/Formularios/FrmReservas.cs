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
        List<Reservas> lReservas = new List<Reservas>();
        List<Peliculas> lPeliculas = new List<Peliculas>();
        List<Clientes> lClientes = new List<Clientes>();
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
            CargarListas();
        }

        private void cargarReservas()
        {
            DataTable dt = helper.consultaSql("select * from Reservas");

            foreach (DataRow dr in dt.Rows)
            {
                Reservas reserva = new Reservas();
                reserva.FechaReserva = Convert.ToDateTime(dr["fecha_reserva"]);
                reserva.HoraConfirmacion = Convert.ToDateTime(dr["hora_confirmacion"]);
                reserva.Pelicula = lPeliculas[Convert.ToInt32(dr["id_pelicula"]) - 1];
                reserva.Cliente = lClientes[Convert.ToInt32(dr["id_cliente"]) - 1];

                lReservas.Add(reserva);
                dgvReservas.Rows.Add(dr["id_reserva"].ToString(), reserva.Cliente.ToString(), reserva.FechaReserva, reserva.Pelicula.ToString()); ;
            }

            
        }

        private void cargarCbo(ComboBox cbo, string select, string display, string value)
        {
            cbo.DataSource = helper.consultaSql(select);
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }

        private void CargarListas()
        {
            DataTable dt = helper.consultaSql("Select * from Peliculas");
            foreach(DataRow dr in dt.Rows)
            {
                Peliculas pelicula = new Peliculas();
                pelicula.Descripcion = dr["descripcion_pelicula"].ToString();
                pelicula.Nombre = dr["nombre_pelicula"].ToString();
                lPeliculas.Add(pelicula);
            }
            DataTable dtc = helper.consultaSql("Select * from Clientes");
            foreach (DataRow drc in dtc.Rows)
            {
                Clientes c = new Clientes();
                c.Apellido = drc["apellido"].ToString();
                c.Nombre = drc["nombre"].ToString();
                c.Socio = Convert.ToBoolean(drc["socio"]);
                c.eMail = drc["email"].ToString();
                lClientes.Add(c);
            }



        }
    }
}
