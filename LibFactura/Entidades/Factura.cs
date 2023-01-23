using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Entidades
{
    public class Factura
    {
        public Factura(string razonsocial) 
        {
            RazonSocial= razonsocial;
        }
        public string RazonSocial { get; set; }

        public List<DetalleFactura> DetalleFacturas { get; set; }
        public Empleado Empleado { get; set; }
        public Cliente Cliente { get; set; }
    }
}
