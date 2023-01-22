using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAviones.Entidades
{
    public class AvionCarga : Avion
    {
        AvionCarga(string piloto, string copiloto, string azafata, int peso, string tipoCarga) : base(piloto, copiloto, azafata)
        {
            Peso = peso;
            TipoCarga = tipoCarga;
        }

        public int Peso { get; set; }
        public string TipoCarga { get; set; }

        public override string Aterrizar()
        {
            return "Avion de carga aterrizando...";
        }
        public override string Despegar()
        {
            return "Avion de carga despegando...";
        }
    }
}
