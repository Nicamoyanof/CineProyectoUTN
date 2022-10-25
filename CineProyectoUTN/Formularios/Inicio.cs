using CineProyectoUTN.Dominios;
using CineProyectoUTN.Formularios;

namespace CineProyectoUTN
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            FrmPersonal frmPersonal = new FrmPersonal();
            frmPersonal.Show();
        }

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    FrmClientes frmCliente = new FrmClientes();
        //    frmCliente.Show();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPeliculas frmPeliculas = new FrmPeliculas();
            frmPeliculas.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmVentas frmVentas = new FrmVentas();
            frmVentas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmReservas frmReservas = new FrmReservas();
            frmReservas.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Funcion frmFuncion = new Funcion();
            frmFuncion.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
        }
    }
}