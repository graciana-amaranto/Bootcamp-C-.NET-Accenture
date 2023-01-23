using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Entidades
{
    public class Categoria
    {
        public string CategoriaProducto { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
