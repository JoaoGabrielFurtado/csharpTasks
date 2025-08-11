using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal class Interno : Funcionario
    { 
        public decimal Salario { get; set; }

        public Interno(string n, string c, decimal s) : base (n, c) 
        { 
            Salario = s;
        }

    }
}
