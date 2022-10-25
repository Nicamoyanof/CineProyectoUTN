﻿using System;
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

namespace CineProyectoUTN.Formularios
{
    public partial class FrmPeliculas : Form
    {

        List<Peliculas> lPeliculas = new List<Peliculas>();
        List<GeneroPelicula> lGeneroPelicula = new List<GeneroPelicula>();
        List<EdadesPermitidas> lEdadesPermitidas = new List<EdadesPermitidas>();
        Peliculas peliculaSeleccionada;
        Helper helper;

        public FrmPeliculas()
        {
            InitializeComponent();
            helper = new Helper();
        }

        private void FrmPeliculas_Load(object sender, EventArgs e)
        {
            CargarGeneros();
            CargarEdades();
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
            DataTable table = helper.consultaSql("SELECT * FROM PELICULAS");
            foreach (DataRow dr in table.Rows)
            {
                Peliculas pelicula = new Peliculas();
                pelicula.Descripcion = dr["descripcion_pelicula"].ToString();
                pelicula.Nombre = dr["nombre_pelicula"].ToString();
                pelicula.Genero = lGeneroPelicula[(Convert.ToInt32(dr["id_genero_pelicula"].ToString())) - 1];
                pelicula.EdadMinima = lEdadesPermitidas[(Convert.ToInt32(dr["id_edad_permitida"].ToString())) - 1];

                lPeliculas.Add(pelicula);
                dgvPeliculas.Rows.Add(dr["id_pelicula"].ToString(), pelicula.Nombre, pelicula.Genero.ToString(), pelicula.EdadMinima.ToString());

            }
        }

        public void CargarGeneros()
        {
            DataTable table = helper.consultaSql("SELECT * FROM Generos_peliculas");
            foreach (DataRow dr in table.Rows)
            {
                GeneroPelicula genero = new GeneroPelicula();
                genero.Nombre = dr["nombre_genero"].ToString();
                genero.Descripcion = dr["descripcion_genero"].ToString();

                lGeneroPelicula.Add(genero);

                cboGeneros.Items.Add(genero.ToString());

            }
        }

        public void CargarEdades()
        {
            DataTable table = helper.consultaSql("SELECT * FROM Edades_permitidas");
            foreach (DataRow dr in table.Rows)
            {
                EdadesPermitidas edades = new EdadesPermitidas();
                edades.Nombre = dr["nombre_edad"].ToString();
                edades.Edad = int.Parse(dr["minimo_edad"].ToString());

                lEdadesPermitidas.Add(edades);


            }
        }

        private void dgvPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = int.Parse(dgvPeliculas.CurrentRow.Cells[0].Value.ToString());
            peliculaSeleccionada = lPeliculas[index - 1];
            SeleccionarPelicula(peliculaSeleccionada);
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
            HabilitarEdicion(true);
        }

        private void SeleccionarPoster(Peliculas peliculas)
        {
            switch (peliculas.Nombre)
            {
                case "American History X":
                    break;
                case "Infiltrados":
                    break;
                case "Sospechosos habituales":
                    break;
                case "El truco final":
                    break;
                case "Casablanca":
                    break;
                case "Whiplash":
                    break;
                case "Intocable":
                    break;
                case "La tumba de las luciérnagas":
                    break;
                case "Hasta que llegó su hora":
                    break;
                case "La ventana indiscreta":
                    break;
                case "Alien":
                    break;
                case "Luces de la ciudad":
                    break;
                case "Cinema Paradiso":
                    break;
                case "Apocalypse Now":
                    break;
                case "Memento":
                    break;
                case "En busca del arca perdida":
                    break;
                case "Django desencadenado":
                    break;
                case "La vida de los otros":
                    break;
                case "WALL·E":
                    break;
                case "Senderos de gloria":
                    break;

                default:
                    break;
            }
        }

    }

}

