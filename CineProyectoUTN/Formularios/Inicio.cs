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

        private void button7_Click(object sender, EventArgs e)
        {
            FrmClientes frmCliente = new FrmClientes();
            frmCliente.Show();
        }
    }
}