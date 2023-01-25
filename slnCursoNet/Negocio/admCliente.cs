using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Modelos;

namespace Negocio
{
    public static class admCliente
    {
        public static List<ClienteIndividuo> clienteIndividuos = new List<ClienteIndividuo>();
        

           public static List<ClienteIndividuo> ListarClienteIndividuo()
        {
            return clienteIndividuos;
        }

        public static ClienteIndividuo ListarClienteIndividuo(string CUIT)
        {
            ClienteIndividuo cliente_Individuo = new ClienteIndividuo("Claudio", "Rol", "32332432432", "claudiorol32@gmail.com","1154789034", "Avenida de mayo 2243");
            return cliente_Individuo;

        }



        public static List<Empresa> clienteEmpresa = new List<Empresa>();


        public static List<Empresa> ListarClienteEmpresa()
        {
            return clienteEmpresa;
        }

        public static Empresa ListarClienteEmpresa(string CUIT)
        {
            Empresa cliente_Empresa = new Empresa("Panaderia Filg", "74129323842", "Marcos Perez", "panaderiafilg@gmail.com", "45678123", "Avenida de Mayo 2245");
            return cliente_Empresa;

        }


    }


    }
}
