using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Remito:DocumentoComercial
    {
        public Remito(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVENTA, string detalle, DateTime fechaEntrega, decimal total) : base(numero, fecha, cliente, direccion, condicionIVA, condicionVENTA, detalle, total)
        {
            
           
            FechaEntrega = fechaEntrega;
          
        }

        

        public DateTime FechaEntrega { get; set; }
        
    }
}
