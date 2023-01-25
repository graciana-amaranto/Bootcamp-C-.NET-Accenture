using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEscuela
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Apellido { get; set; }

        private string Nombre;
        public string nombre
        {
            get { return Nombre; }
            set {
                if (value.Trim().Length < 1)
                {
                    throw new Exception("El nombre ingresado no puede estar vacio");
                }
                else if (value.Trim().Length > 50)
                {
                    throw new Exception("El nombre ingresado nono puede tener mas de 50 caracteres");
                }
                else
                {
                    Nombre = value.Trim();
                }
            }
        }

    }
}
