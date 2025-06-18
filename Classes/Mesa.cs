using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloRestaurante.Classes
{
    public class Mesa
    {
        public int NumeroMesa { get; set; }
        public bool EstaOcupada { get; set; }

        public Mesa(int numeroMesa)
        {
            NumeroMesa = numeroMesa;
            EstaOcupada = false;
        }
    }
}
