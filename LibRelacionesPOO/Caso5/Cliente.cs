using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso5
{
    public class Cliente
    {
        public string Apellido { get; set; }
        public int DNI { get; set; }

        public List<DatosContacto> DatosContactos { get; set; }
    }
}
