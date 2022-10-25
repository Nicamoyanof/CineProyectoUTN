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
        public FrmClientes()
        {
            InitializeComponent();
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
    }
}
