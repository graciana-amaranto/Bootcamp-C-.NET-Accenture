using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class ClienteIndividuo:Persona
    {
       
        public ClienteIndividuo(string nombre, string apellido, string cuit, string email, string telefono, string direccion) : base(nombre, apellido, email, telefono,direccion)
        {
            
            CUIT = cuit;
            
        }

        public string CUIT { get; set; }
        

    }
}
