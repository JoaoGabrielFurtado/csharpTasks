using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloRestaurante.Classes
{
    public class Pedido
    {

        public int NumeroMesa { get; set; }
        public int IdPedido { get; set; }
        public string NomePedido { get; set; }

        public string PedidoCompleto => $"A mesa de número {NumeroMesa} realizou o pedido: {NomePedido} ";


    }
}
