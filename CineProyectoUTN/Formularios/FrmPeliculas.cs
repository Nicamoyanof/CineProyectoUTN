using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineProyectoUTN.Dominios;
using CineProyectoUTN.Datos;
using CineProyectoUTN.Fachada.Interfaz;
using CineProyectoUTN.Fachada.Implementacion;

namespace CineProyectoUTN.Formularios
{
    public partial class FrmPeliculas : Form
    {

        List<Peliculas> lPeliculas = null;
        Peliculas peliculaSeleccionada;
        IPeliculasApi dao;


        public FrmPeliculas()
        {
            InitializeComponent();
            dao = new PeliculasApiImp();
        }

        private void FrmPeliculas_Load(object sender, EventArgs e)
        {
            CargarGeneros();
            CargarPeliculas();
            HabilitarEdicion(true);
        }

        private void recaudacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecaudacionPelicula frmRecaudacionPelicula = new FrmRecaudacionPelicula();
            frmRecaudacionPelicula.Show();
        }

        public void CargarPeliculas()
        {
            dgvPeliculas.Rows.Clear();

            lPeliculas = dao.ObtenerPeliculas();

            foreach (Peliculas pelicula in lPeliculas)
            {
                dgvPeliculas.Rows.Add(pelicula.IdPelicula, pelicula.Nombre, pelicula.Genero.ToString(), pelicula.EdadMinima.ToString());
            }
        }

        public void CargarGeneros()
        {

            List<GeneroPelicula> lGeneros = dao.ObtenerGeneros();

            foreach (GeneroPelicula genero in lGeneros)
            {
                cboGeneros.Items.Add(genero.ToString());
            }
        }


        private void dgvPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = int.Parse(dgvPeliculas.CurrentRow.Cells[0].Value.ToString());
            peliculaSeleccionada = lPeliculas[index - 1];
            SeleccionarPelicula(peliculaSeleccionada);
            SeleccionarPoster(peliculaSeleccionada);
        }

        private void SeleccionarPelicula(Peliculas pelicula)
        {
            txtNombre.Text = pelicula.Nombre;
            cboGeneros.SelectedItem = pelicula.Genero.Nombre;
            txtDescripcion.Text = pelicula.Descripcion;
            switch (pelicula.EdadMinima.Edad)
            {
                case 0:
                    rbATP.Checked = true;
                    break;
                case 13:
                    rbTrece.Checked = true;
                    break;
                case 15:
                    rbQuince.Checked = true;
                    break;
                case 18:
                    rbDieciocho.Checked = true;
                    break;
                default:
                    break;
            }
            HabilitarEdicion(false);
        }



        public void HabilitarEdicion(bool habilitar)
        {
            txtNombre.Enabled = habilitar;
            cboGeneros.Enabled = habilitar;
            txtDescripcion.Enabled = habilitar;
            rbATP.Enabled = habilitar;
            rbTrece.Enabled = habilitar;
            rbQuince.Enabled = habilitar;
            rbDieciocho.Enabled = habilitar;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = false;
            btnBorrar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            cboGeneros.SelectedIndex = -1;
            txtDescripcion.Text = string.Empty;
            rbATP.Checked = false;
            rbTrece.Checked = false;
            rbQuince.Checked = false;
            rbDieciocho.Checked = false;
            pictureBox1.Image = null;
            HabilitarEdicion(true);
        }

        private void SeleccionarPoster(Peliculas peliculas)
        {
            pictureBox1.Image = Image.FromFile($"../../../Assets/Poster/{peliculas.NombrePoster}.jpg"); ;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

}

