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
            CargarListas();
            CargarPeliculas();
            cargarCbo(cboFuncion ,"SELECT * FROM Funciones", "horario", "id_funcion");
            cargarCbo(cboCliente, "SELECT * FROM Clientes", "apellido", "id_cliente");
            cargarCbo(cboFomaPago, "SELECT * FROM Tipos_Pagos", "nombre_tipo_pago", "id_tipo_pago");
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
            cboFomaPago.SelectedIndex = -1;
            cboCliente.SelectedIndex = -1;
            dtpConfirmacion.Value = DateTime.Now;
            dtpReserva.Value = DateTime.Now;
            txtPrecio.Text.Equals(string.Empty);
            txtPrecio.Enabled = !v;
            numCantTicket.Enabled = !v;
        }

        private void cargarReservas()
        {
            DataTable dt = helper.consultaSql("select * from Reservas");

            foreach (DataRow dr in dt.Rows)
            {
                Reservas reserva = new Reservas();
                reserva.FechaReserva = Convert.ToDateTime(dr["fecha_reserva"]);
                reserva.HoraConfirmacion = Convert.ToDateTime(dr["hora_confirmacion"]);
               // reserva.Pelicula = lPeliculas[Convert.ToInt32(dr["id_funcion"])-1]; VER
                reserva.Cliente = lClientes[Convert.ToInt32(dr["id_cliente"])-1];


                lReservas.Add(reserva);

                dgvReservas.Rows.Add(new object[] { dr["id_reserva"].ToString(), 
                    reserva.Cliente.ToString(), reserva.FechaReserva,
                    reserva.Pelicula.Nombre 
                });
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
        public void CargarPeliculas()
        {
            DataTable dt = helper.consultaSql("Select * from Peliculas");
            foreach (DataRow dr in dt.Rows)
            {
                string Descripcion = dr["descripcion_pelicula"].ToString();
                string Nombre = Convert.ToString(dr["nombre_pelicula"]);
                EdadesPermitidas EdadMinima = new EdadesPermitidas();
                GeneroPelicula Genero = new GeneroPelicula();
                
                Peliculas pelicula = new Peliculas(Nombre, EdadMinima, Genero, Descripcion);
               // pelicula.Descripcion = dr["descripcion_pelicula"].ToString();
               // pelicula.Nombre = Convert.ToString(dr["nombre_pelicula"]);
               // pelicula.Genero = null;
               // pelicula.EdadMinima = null;

                lPeliculas.Add(pelicula);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitar(true);
        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = int.Parse(dgvReservas.CurrentRow.Cells[0].Value.ToString());
            Reservas ReservaSeleccionada = lReservas[index - 1];
            SeleccionarPelicula(ReservaSeleccionada);
        }

        private void SeleccionarPelicula(Reservas reserva)
        {
            cboCliente.Text = reserva.Cliente.ToString();
            cboFuncion.Text = reserva.Pelicula.ToString();
            dtpConfirmacion.Text = reserva.HoraConfirmacion.ToString();
            dtpReserva.Text = reserva.FechaReserva.ToString();
            //Faltan agregar
        }
    }
}
