using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineProyectoUTN.Dominios
{
    internal class Reservas
    {
        public Reservas()
        {
            Cliente = new Clientes();
            Pelicula = new Peliculas();
            FechaReserva = DateTime.Now;
            HoraConfirmacion = DateTime.Now;
        }

        public Clientes Cliente { get; set; }
        public Peliculas Pelicula { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime HoraConfirmacion { get; set; }
    }
}