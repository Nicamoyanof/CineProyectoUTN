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
    public partial class FrmPersonal : Form
    {
        private Helper oDatos;
        private FrmClientes frmCli = new FrmClientes();

        public FrmPersonal()
        {
            InitializeComponent();
            oDatos = new Helper();
        }
        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = frmCli.cargarCombo("SELECT * FROM TIPOS_CARGOS");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ValueMember = "id_tipo_cargo";
            comboBox1.DisplayMember = "nombre_cargo";
            comboBox2.DataSource = frmCli.cargarCombo("SELECT * FROM CIUDADES");
            comboBox2.ValueMember = "id_ciudad";
            comboBox2.DisplayMember = "nombre_ciudad";
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            DataTable tabla = 
                oDatos.consultaSql("select apellido_empleado 'Apellido', nombre_empleado 'Nombre'," +
                " fecha_nac 'Fecha de nacimiento', telefono 'Telefono', cuil 'Cuil', fecha_ingreso" +
                "'Fecha de ingreso', nombre_cargo 'Cargo'" +
                ",nombre_ciudad 'Ciudad' from Empleados e join ciudades ciu on e.id_ciudad = ciu.id_ciudad join tipos_cargos t on t.id_tipo_cargo = e.id_tipo_cargo");
            dataGridView1.DataSource = tabla;
        }
        private void vacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleadosVacaciones frmEmpleadosVacaciones = new FrmEmpleadosVacaciones();
            frmEmpleadosVacaciones.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedCells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView1.SelectedCells[5].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
