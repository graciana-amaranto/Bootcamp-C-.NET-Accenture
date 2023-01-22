using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso4
{
    public class Docente
    {
        public string Nombre { get; set; }
        public string Escuela { get; set; }

        public List<Alumno> Alumnos { get; set;}
    }
}
