using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Entidades
{
    public class Empleado: Persona
    {
        public Empleado(int nroempleado, string puesto, string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        { 
            NroEmpleado= nroempleado;
            Puesto= puesto;
        }
        
        public int NroEmpleado { get; set; }
        public string Puesto { get; set; }

        public List<Factura> Facturas { get; set; }
    }
}
