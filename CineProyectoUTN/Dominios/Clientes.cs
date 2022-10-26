using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineProyectoUTN.Dominios
{
    internal class Clientes
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string eMail { get; set; }
        public DateTime FechaNac { get; set; }
        public bool Socio { get; set; }

        public override string ToString()
        {
            return Apellido + " " + Nombre;
        }

    }
}
