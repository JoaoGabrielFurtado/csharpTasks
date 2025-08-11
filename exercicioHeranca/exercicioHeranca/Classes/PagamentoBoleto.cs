using exercicioHeranca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal class PagamentoBoleto : PessoaPagamento, IPagamento
    {
        public PagamentoBoleto(string nome, string email) : base(nome, email)
        {
        }

        public void ProcessarPag()
        {
            Console.WriteLine($"Processando pagamento via boleto para {nome} - {email}");
        }

    }
}
