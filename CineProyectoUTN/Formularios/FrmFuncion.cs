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

namespace CineProyectoUTN.Formularios
{
    public partial class Funcion : Form
    {

        List<Funciones> lFunciones = new List<Funciones>();
        List<Peliculas> lPeliculas = new List<Peliculas>();
        List<Salas> lSalas = new List<Salas>();
        List<Asientos> lAsientos = new List<Asientos>();
        List<GeneroPelicula> lGeneroPelicula = new List<GeneroPelicula>();
        List<EdadesPermitidas> lEdadesPermitidas = new List<EdadesPermitidas>();
        List<TipoSala> lTipoSala = new List<TipoSala>();
        Helper helper;

        public Funcion()
        {
            InitializeComponent();

            helper = new Helper();

            for (int i = 1; i <= 20; i++)
            {
                lAsientos.Add(new Asientos(i, true));
            }
        }

        private void Funcion_Load(object sender, EventArgs e)
        {
            CargarTipoSalas();
            CargarGeneros();
            CargarEdades();
            CargarAsientos();
            CargarFuncion();

        }

        private void CargarAsientos()
        {
            dgvAsientos.Rows.Clear();
            var C1 = new DataGridViewButtonColumn() { Name = "C1" };
            C1.FlatStyle = FlatStyle.Flat;
            C1.DefaultCellStyle.BackColor = Color.Red;

            int asiento = 0;
            for (int i = 0; i < lAsientos.Count() / 4; i++)
            {

                dgvAsientos.Rows.Add(
                lAsientos[asiento].NumeroAsiento,
                lAsientos[asiento + 1].NumeroAsiento,
                lAsientos[asiento + 2].NumeroAsiento,
                lAsientos[asiento + 3].NumeroAsiento);

                for (int j = 0; j < 4; j++)
                {

                    if (!lAsientos[j + i * 4].Disponible)
                    {
                       dgvAsientos.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        dgvAsientos.Rows[i].Cells[j].Style.BackColor = Color.Green;
                    }
                }
                asiento += 4;
            }
        }

        public void CargarFuncion()
        {
            dgvFunciones.Rows.Clear();
            DataTable table = helper.consultaSql("SELECT * FROM Funciones WHERE DAY(horario) = 01");

            foreach (DataRow dataRow in table.Rows)
            {
                Funciones funcion = new Funciones();

                funcion.Pelicula = CargarPeliculaById(int.Parse(dataRow["id_pelicula"].ToString()));
                funcion.Sala = CargarSala(int.Parse(dataRow["id_sala"].ToString()));
                funcion.Horario = Convert.ToDateTime(dataRow["horario"].ToString());
                lFunciones.Add(funcion);
                dgvFunciones.Rows.Add(dataRow["id_funcion"].ToString(), funcion.Pelicula.ToString(), funcion.Sala.ToString(), funcion.Horario);

            }

        }

        public Peliculas CargarPeliculaById(int id)
        {
            DataTable table = helper.consultaSql("SELECT * FROM Peliculas WHERE id_pelicula=" + id);

            Peliculas pelicula = new Peliculas();

            foreach (DataRow dr in table.Rows)
            {
                pelicula.Descripcion = dr["descripcion_pelicula"].ToString();
                pelicula.Nombre = dr["nombre_pelicula"].ToString();
                pelicula.Genero = lGeneroPelicula[(Convert.ToInt32(dr["id_genero_pelicula"].ToString())) - 1];
                pelicula.EdadMinima = lEdadesPermitidas[(Convert.ToInt32(dr["id_edad_permitida"].ToString())) - 1];

            }

            return pelicula;

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

        public Salas CargarSala(int id)
        {
            DataTable salas = helper.consultaSql("SELECT * FROM Salas WHERE id_sala =" + id);
            Salas sala = new Salas();
            foreach (DataRow dr in salas.Rows)
            {
                sala.TipoSala = lTipoSala[Convert.ToInt32(dr["id_tipo_sala"].ToString()) - 1];
                sala.NumeroSala = Convert.ToInt32(dr["numero_sala"].ToString());
                sala.LstAsientos = new List<Asientos>();

            }
            return sala;
        }


        public void CargarTipoSalas()
        {
            DataTable table = helper.consultaSql("SELECT * FROM Tipos_Salas");
            foreach (DataRow dr in table.Rows)
            {
                TipoSala tipoSala = new TipoSala();
                tipoSala.Nombre = dr["nombre_tipo_sala"].ToString();
                tipoSala.Descripcion = dr["descripcion_tipo_sala"].ToString();
                tipoSala.Precio = float.Parse(dr["precio_sala"].ToString());

                lTipoSala.Add(tipoSala);
            }
        }

        private void dgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            HabilitarEdicion(false);

            lAsientos.Clear();

            for (int i = 1; i <= 20; i++)
            {
                lAsientos.Add(new Asientos(i, true));
            }

            int index = int.Parse(dgvFunciones.CurrentRow.Cells[0].Value.ToString());
            Funciones func = lFunciones[index - 1];
            txtPelicula.Text = func.Pelicula.ToString();
            txtSala.Text = func.Sala.ToString();
            dtpHorario.Value = func.Horario;
            AsientosOcupados(index);
        }

        public void AsientosOcupados(int id)
        {
            DataTable ticket = helper.consultaSql("SELECT * FROM Tickets WHERE id_funcion = " + id);
            foreach (DataRow dr in ticket.Rows)
            {
                DataTable detalle_ticket = helper.consultaSql("SELECT * FROM Detalles_Tickets WHERE id_ticket = " + dr["id_ticket"].ToString());

                foreach (DataRow dataRow in detalle_ticket.Rows)
                {
                    DataTable asiento_sala = helper.consultaSql("SELECT * FROM Asientos_Por_Salas WHERE id_asiento_sala = " + dataRow["id_asiento_sala"].ToString());

                    foreach (DataRow asrow in asiento_sala.Rows)
                    {
                        AsientoOcupado(int.Parse(asrow["id_asiento"].ToString()));
                    }
                }
            }
        }

        public void AsientoOcupado(int index)
        {
            lAsientos[index-1].Disponible = false;
            CargarAsientos();
        }

        public void HabilitarEdicion(bool habilitar)
        {
            txtPelicula.Enabled = habilitar;
            txtSala.Enabled = habilitar;
            dtpHorario.Enabled = habilitar;

            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = false;
            btnBorrar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarEdicion(true);
        }
    }
}
