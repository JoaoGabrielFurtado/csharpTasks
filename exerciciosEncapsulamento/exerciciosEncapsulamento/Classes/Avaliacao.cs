using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosEncapsulamento.Classes
{
    internal class Avaliacao
    {
        public string NomeAluno { get; }
        public double Nota { get; private set; }

        public Avaliacao(string n) { NomeAluno = n; }

        public void AtribuirNota(double nota)
        {
            if (nota < 0 || nota > 10)
            {
                Console.WriteLine($"Nota {nota} inválida");
                return;
            }

            Nota = nota;
            Console.WriteLine($"Nota {nota} atribuída ao aluno {NomeAluno}");

        }

    }
}
