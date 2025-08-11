using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosEncapsulamento.Classes
{
    internal class SegurancaConta
    {
        public double ValidarSaque(double valor)
        {
            if (valor > 1000)
                return 0;

            return valor;
        }
    }
}
