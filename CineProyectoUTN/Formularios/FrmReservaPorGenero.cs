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
    public partial class FrmReservaPorGenero : Form
    {
        List<Parametro> lParametro = new List<Parametro>();
        Helper helper = new Helper();
        Parametro pEdad;
        Parametro pGenero;
        public FrmReservaPorGenero()
        {
            InitializeComponent();
        }

        private void FrmReservaPorGenero_Load(object sender, EventArgs e)
        {
            cargarCbo(cboGenero, "SELECT * FROM Generos_peliculas", "nombre_genero", "id_genero_pelicula");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarConsulta();
            button1.Enabled = false;
        }

        private void CargarConsulta()
        {
            string sp = "sp_reservas_terror";
            pGenero = new Parametro("@Genero", cboGenero.Text);
            pEdad = new Parametro("@edad", numericUpDown1.Value);
            lParametro.Add(pGenero);
            lParametro.Add(pEdad);

            DataTable table = helper.ConsultaSQLSP(sp, lParametro);
            dataGridView1.DataSource = table;
        }
        private void cargarCbo(ComboBox cbo, string select, string display, string value)
        {
            cbo.DataSource = helper.consultaSql(select);
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
