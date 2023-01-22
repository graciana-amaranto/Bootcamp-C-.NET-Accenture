using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAviones.Entidades
{
    public class AvionComercial: Avion
    {
        
        public AvionComercial(double capacidad, string lineaAerea, string piloto, string copiloto, string azafata) : base(piloto, copiloto, azafata)
        {
            Capacidad = capacidad;
            LineaAerea = lineaAerea;
        }

        public double Capacidad { get; set; }
        public string LineaAerea { get; set; }

        public override string Aterrizar()
        {
            return "Avion comercial aterrizando...";
        }
        public override string Despegar()
        {
            return "Avion comercial despegando...";
        }
    }
}
