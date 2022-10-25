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
        }

        private void vacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleadosVacaciones frmEmpleadosVacaciones = new FrmEmpleadosVacaciones();
            frmEmpleadosVacaciones.Show();
        }
    }
}
