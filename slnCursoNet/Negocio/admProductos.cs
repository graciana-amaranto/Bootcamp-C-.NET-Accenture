using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Modelos;

namespace Negocio
{
    public static class admProductos
    {
        public static List<Producto> productos = new List<Producto>();


        public static List<Producto> Listar()
        {
            
            return productos;
           
        }


        public static List<Producto> Listar(string categoria)
        {
            Producto producto = new Producto("Pan", "Pan frances", (decimal)450.90, 0.2, 0.21, "Panaderia Filg", "Panificados", "Panes");
            return productos;

        }

        public static List<Producto> Listar(string categoria, string subCategoria)
        {
            Producto producto = new Producto("Pan", "Pan frances", (decimal)450.90, 0.2, 0.21, "Panaderia Filg", "Panificados", "Panes");
            return productos;

        }


        public static List<Producto> ListarDetalle(string Nombre)
        {

            return productos;

        }


    }
}
