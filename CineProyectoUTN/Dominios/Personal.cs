using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineProyectoUTN.Dominios
{
    internal class Personal
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Telefono { get; set; }
        public string Cuil { get; set; }
        public DateTime FechaNac { get; set; }

        public Personal(int id, string nom, string ape, DateTime fecIngreso, string tel, string cuil, DateTime fecNac)
        {
            IdEmpleado = id;
            Nombre = nom;
            Apellido = ape;
            FechaIngreso = fecIngreso;
            Telefono = tel;
            Cuil = cuil;
            FechaNac = fecNac;
        }
    }
}
