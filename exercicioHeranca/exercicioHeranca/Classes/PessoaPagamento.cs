using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal abstract class PessoaPagamento
    {
        public string nome;
        public string email;
        public PessoaPagamento(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }
    }
}
