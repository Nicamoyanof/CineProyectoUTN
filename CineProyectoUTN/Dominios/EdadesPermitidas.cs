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

        public override string ToString()
        {
            switch (Edad)
            {
                case 0:
                    return "Apto para todo publico";
                case 13:
                    return "Apto mayores de 13 años";
                case 15:
                    return "Apto mayores de 15 años";
                case 18:
                    return "Apto mayores de 18 años";
                default:
                    return "Error";
            }
        }

    }
}
