using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Entidades
{
    public class Cliente: Persona
    {
        public Cliente(int nrocliente, string direccion, string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            NroCliente= nrocliente;
            Direccion= direccion;
        }   
        public int NroCliente { get; set; }
        public string Direccion { get; set; }

        public List<Factura> Facturas { get; set;}
        public Usuario Usuario { get; set; }
    }
}
