using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Factura:DocumentoComercial
    {
        public Factura(string tipo, string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVENTA, string detalle, decimal total) : base(numero, fecha, cliente, direccion, condicionIVA,condicionVENTA,detalle,total)
        {
            Tipo = tipo;
           
        }

        public string Tipo { get; set; }
     
    }
}
