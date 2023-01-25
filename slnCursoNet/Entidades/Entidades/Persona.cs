﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public abstract class Persona
    {
        protected Persona(string nombre, string apellido, string email, string telefono, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set;}
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
