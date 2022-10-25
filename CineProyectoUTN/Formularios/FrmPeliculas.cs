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
    public partial class FrmPeliculas : Form
    {
        public FrmPeliculas()
        {
            InitializeComponent();
        }

        private void FrmPeliculas_Load(object sender, EventArgs e)
        {

        }

        private void recaudacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecaudacionPelicula frmRecaudacionPelicula = new FrmRecaudacionPelicula();
            frmRecaudacionPelicula.Show();
        }
    }
}
