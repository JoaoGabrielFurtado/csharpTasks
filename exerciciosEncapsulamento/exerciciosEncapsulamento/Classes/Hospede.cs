using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosEncapsulamento.Classes
{ 
   public class Hospede
    {

        public string Nome { get; set; }

        public Hospede(string n)
        {
            Nome = n;
        }
    }
}
