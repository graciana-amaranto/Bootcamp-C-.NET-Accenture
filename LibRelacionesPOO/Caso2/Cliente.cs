using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.Caso2
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Pedido> Pedidos { get; set; }
    }
}
