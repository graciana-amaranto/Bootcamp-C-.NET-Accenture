using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso3
{
    public class Tripulacion
    {
        public int Cantidad { get; set; }
        public string Nombre { get; set; }

        public List<Azafata> Azafatas { get;set; }
    }
}
