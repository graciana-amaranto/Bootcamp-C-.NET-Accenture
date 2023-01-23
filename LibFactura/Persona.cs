using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Entidades
{
    public abstract class Persona
    {
        public Persona(string nombre, string apellido, int dni) 
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI= dni;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }


    }
}
