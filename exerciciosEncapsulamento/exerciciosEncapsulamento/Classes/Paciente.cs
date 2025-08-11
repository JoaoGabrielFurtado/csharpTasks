using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosEncapsulamento.Classes
{
    public class Paciente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Paciente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
