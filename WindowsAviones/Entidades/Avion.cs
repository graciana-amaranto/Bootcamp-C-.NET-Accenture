using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAviones.Entidades
{
    public abstract class Avion
    {
        public Avion(string piloto, string copiloto, string azafata)
        {
            Piloto = piloto;
            Copiloto = copiloto;
            Azafata = azafata;
        }
        public string Piloto { get; set; }
        public string Copiloto { get; set; }
        public string Azafata { get; set; }

        public abstract string Aterrizar();
        public abstract string Despegar();
    }
}
