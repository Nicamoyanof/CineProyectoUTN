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
    public partial class FrmClientesExtranjeros : Form
    {
        List<Parametro> lParametro = new List<Parametro>();
        Helper helper = new Helper();
        Parametro param;
        public FrmClientesExtranjeros()
        {
            InitializeComponent();
        }

        private void FrmClientesExtranjeros_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarConsulta();
        }

        private void CargarConsulta()
        {
            string sp = "sp_clientes_extranjeros";
            param = new Parametro("@MinimoPelicuas", numericUpDown1.Value);
           // parametro.add(new Parametro("@MinimoPeliculas", numericUpDown1.Value));
            lParametro.Add(param);
            DataTable table = helper.ConsultaSQLSP(sp, lParametro);
            dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

