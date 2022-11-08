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
    public partial class Funcion : Form
    {

        List<Funciones> lFunciones = new List<Funciones>();
        List<Peliculas> lPeliculas = new List<Peliculas>();
        List<Salas> lSalas = new List<Salas>();
        List<Asientos> lAsientos = new List<Asientos>();
        List<GeneroPelicula> lGeneroPelicula = new List<GeneroPelicula>();
        List<EdadesPermitidas> lEdadesPermitidas = new List<EdadesPermitidas>();
        List<TipoSala> lTipoSala = new List<TipoSala>();

        IPeliculasApi daoPelicula;
        ISalasApi daoSala;
        IFuncionesApi daoFunc;

        public Funcion()
        {
            InitializeComponent();

            daoPelicula = new PeliculasApiImp();
            daoSala = new SalasApiImp();
            daoFunc = new FuncionesApiImp();

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

            lFunciones = daoFunc.CargarFunciones();

            foreach (Funciones func in lFunciones)
            {
                dgvFunciones.Rows.Add(func.IdFuncion, func.Pelicula.ToString(), func.Sala.ToString(), func.Horario);
            }

        }

        public Peliculas CargarPeliculaById(int id)
        {
            return daoPelicula.CargarPeliculaPorId(id);

        }

        public void CargarGeneros()
        {
            lGeneroPelicula = daoPelicula.ObtenerGeneros();
        }

        public void CargarEdades()
        {
            lEdadesPermitidas = daoPelicula.ObtenerEdadesPermitidas();
        }

        public Salas CargarSala(int id)
        {
            return daoSala.CargarSalaPorId(id);
        }


        public void CargarTipoSalas()
        {
            lTipoSala = daoSala.CargarTipoSalas();
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

            Funciones func = null;

            foreach (Funciones funciones in lFunciones)
            {
                if (funciones.IdFuncion.Equals(id))
                {
                    func = funciones;
                }
            }

            if (func != null)
            {
                DataTable detalle_ticket = Helper.ObtenerInstancia().ConsultarSQLScript("SELECT * FROM Detalles_Tickets WHERE id_ticket = " + func.IdFuncion);

                foreach (DataRow dataRow in detalle_ticket.Rows)
                {
                    DataTable asiento_sala = Helper.ObtenerInstancia().ConsultarSQLScript("SELECT * FROM Asientos_Por_Salas WHERE id_asiento_sala = " + dataRow["id_asiento_sala"].ToString());

                    foreach (DataRow asrow in asiento_sala.Rows)
                    {
                        AsientoOcupado(int.Parse(asrow["id_asiento"].ToString()));
                    }
                }
            }


        }

        public void AsientoOcupado(int index)
        {
            lAsientos[index - 1].Disponible = false;
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

        private void entradasVendidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmClienteFuncion frmClienteFuncion = new FrmClienteFuncion();
            //frmClienteFuncion.Show();
        }

        private void dgvFunciones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
    }
}
