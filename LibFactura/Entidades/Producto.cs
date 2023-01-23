using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Entidades
{
    public class Producto
    {
        public string NombreProducto { get; set; }

        public DetalleFactura DetalleFactura { get;set; }
        public Categoria Categoria { get; set; }
    }
}
