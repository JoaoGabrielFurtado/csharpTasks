using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal class Funcionario
    {

        public string Nome { get; set; }
        public string Cargo { get; set; }

        public Funcionario(string n, string c)
        {
            Nome = n;
            Cargo = c;
        }
    }
}
