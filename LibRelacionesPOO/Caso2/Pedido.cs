using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso2
{
    public class Pedido
    {
        public int NroPedido { get; set; }
        public string EstadoPedido { set; get; }
        public Cliente Cliente { get; set; }
    }
}
