using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosEncapsulamento.Classes
{
    public class Quarto
    {

        private double _valorDiaria;
        public int Numero { get; }      
        public double ValorDiaria
        {
            get { return _valorDiaria; }
            set
            {
                if (value > 0)
                    _valorDiaria = value;
            }
        }

        public Quarto(int n)
        {
            Numero = n;
        }

    }
}
