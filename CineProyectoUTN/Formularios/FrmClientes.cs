using CineProyectoUTN.Datos;
using CineProyectoUTN.Dominios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineProyectoUTN.Formularios
{
    public partial class FrmClientes : Form
    {
        private Helper oDatos;
        public FrmClientes()
        {
            InitializeComponent();
            oDatos = new Helper();
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            cargarCombo("SELECT * FROM CIUDADES");
            DataTable tabla = oDatos.consultaSql("select * from clientes");
            dataGridView1.DataSource = tabla;
        }
        public DataTable cargarCombo(string ConsultaSql)
        {
            DataTable tabla = oDatos.consultaSql(ConsultaSql);
            if (tabla != null)
            {
                comboBox1.DataSource = tabla;
                comboBox1.ValueMember = Convert.ToString(tabla.Columns[0]);
                comboBox1.DisplayMember = Convert.ToString(tabla.Columns[1]);
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            return tabla;
        }
        private void cantidadDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCantidadSocios frmCantidadSocios = new FrmCantidadSocios();
            frmCantidadSocios.Show();
        }

        private void clientesExtranjerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientesExtranjeros frmClientesExtranjeros = new FrmClientesExtranjeros();
            frmClientesExtranjeros.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[8].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedCells[4].Value.ToString();
            if (dataGridView1.SelectedCells[5].Value is 0)
            {
                radioButton1.Checked = true;
            }
            else { radioButton2.Checked = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
