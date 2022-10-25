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
        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void vacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleadosVacaciones frmEmpleadosVacaciones = new FrmEmpleadosVacaciones();
            frmEmpleadosVacaciones.Show();
        }
    }
}
