using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Producto
    {
        public Producto(string nombre, string descripcion, decimal precioCosto, double margen, double iVA, string proveedor, string categoria, string subCategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCosto = precioCosto;
            Margen = margen;
            IVA = iVA;
            Proveedor = proveedor;
            Categoria = categoria;
            SubCategoria = subCategoria;
        }

      

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }

        public decimal PrecioBruto
        {
            get
            {

                decimal PrecioBruto = Convert.ToDecimal(1 + this.Margen) * PrecioCosto;
                return PrecioBruto;
            }



        }


        public decimal PrecioVenta
        {
            get
            {
                decimal PrecioVenta = Convert.ToDecimal(1 + this.IVA) * PrecioBruto;
                return PrecioVenta;

            }

        }
    }
}
