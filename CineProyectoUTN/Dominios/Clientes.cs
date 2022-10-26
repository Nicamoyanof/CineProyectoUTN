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
        public DateTime FechaNac { get; set; }
        public string Email { get; set; }
        public bool Socio { get; set; }

        public Clientes(int idcliente, string nombre, string apellido, DateTime fechanac, string email, bool socio)
        {

             this.Nombre = nombre;
             this.Apellido = apellido;
             this.FechaNac = fechanac;
             this.Email = email;
             this.Socio = socio;
        }

        public Clientes()
        {
        }

        public override string ToString()
        {
            return Apellido + " " + Nombre;
        }


    }
}
