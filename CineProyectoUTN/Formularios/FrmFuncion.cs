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

namespace CineProyectoUTN.Formularios
{
    public partial class Funcion : Form
    {

        List<Asientos> lAsientos = new List<Asientos>();

        public Funcion()
        {
            InitializeComponent();

            for (int i = 1; i <= 20; i++)
            {
                lAsientos.Add(new Asientos(i, true));
            }

            lAsientos[5].Disponible = false;
            lAsientos[9].Disponible = false;
            lAsientos[12].Disponible = false;
            lAsientos[19].Disponible = false;
            lAsientos[1].Disponible = false;
            lAsientos[2].Disponible = false;
            lAsientos[11].Disponible = false;


        }

        private void Funcion_Load(object sender, EventArgs e)
        {
            CargarAsientos();

        }

        private void CargarAsientos()
        {
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

    }
}
