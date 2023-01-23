using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Entidades
{
    public class Usuario: Persona
    {
        public Usuario(string nombreUsuario, string contrasenia, string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
        }

        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }

        public Cliente Cliente { get; set; }
    }
}
