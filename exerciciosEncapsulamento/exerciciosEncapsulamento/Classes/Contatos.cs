using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosEncapsulamento.Classes
{
    internal class Contatos
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Contatos(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }


    }
}
