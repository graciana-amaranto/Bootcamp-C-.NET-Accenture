using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public abstract class DocumentoComercial
    {
        public  DocumentoComercial(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVENTA, string detalle, decimal total)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Direccion = direccion;
            CondicionIva = condicionIVA;
            CondicionVenta = condicionVENTA;
            Detalle = detalle;
            Total = total;
        }

        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIva { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        public decimal Total { get; set; }
    }
}
