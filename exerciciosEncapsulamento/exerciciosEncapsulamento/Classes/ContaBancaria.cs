using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosEncapsulamento.Classes
{
    public class ContaBancaria
    {

        private double saldo;
        SegurancaConta sc = new SegurancaConta();

        public string Titular { get; }

        public ContaBancaria(string t, double s)
        {
            Titular = t;
            saldo = s;
        }

        public void Sacar(double valor)
        {
            double saque = sc.ValidarSaque(valor);
            if(saque > 0)
            {
                Console.WriteLine($"Saque de {valor} realizado com sucesso");
                saldo -= saque;
                Console.WriteLine($"Saldo atual: {saldo}");
            } else
            {
                Console.WriteLine("Saque negado pela política de segurança");
            }
        }
    }
}
