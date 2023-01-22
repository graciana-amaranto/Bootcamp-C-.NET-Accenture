using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso4
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public int DNI { get; set; }

        public Docente Docente { get; set; }
    }
}
