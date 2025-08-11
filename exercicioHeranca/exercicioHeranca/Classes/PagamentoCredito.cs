using exercicioHeranca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal class PagamentoCredito : PessoaPagamento, IPagamento
    {
        public PagamentoCredito(string nome, string email) : base(nome, email)
        {
        }
        public void ProcessarPag()
        {
            Console.WriteLine($"Processando pagamento com cartão de crédito para {nome} - {email}");
        }

    }
}
