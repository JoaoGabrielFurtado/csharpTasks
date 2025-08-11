using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal class FreeLancer : Funcionario
    {
        public decimal ValorProjeto { get; set; }

        public FreeLancer(string n, string c, decimal v) : base(n, c)
        {
            ValorProjeto = v;
        }

    }
}
