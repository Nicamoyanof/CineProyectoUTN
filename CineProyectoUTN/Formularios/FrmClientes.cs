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
    }
}
