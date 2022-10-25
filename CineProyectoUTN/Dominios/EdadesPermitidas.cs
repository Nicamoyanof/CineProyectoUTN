using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineProyectoUTN.Dominios
{
    internal class EdadesPermitidas
    {

        public EdadesPermitidas(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        public EdadesPermitidas()
        {
            Nombre = "sin nombre";
            Edad = 0;
        }

        public string Nombre { get; set; }
        public int Edad { get; set; }



    }
}
