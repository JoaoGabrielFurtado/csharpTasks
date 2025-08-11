using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosEncapsulamento.Classes
{
    internal class Agenda
    {

        private readonly List<Contatos> contatos;

        public string Proprietario { get; set; }


        public Agenda(string proprietario)
        {
            Proprietario = proprietario;
            contatos = new List<Contatos>();
        }


        public bool AdicionarContato(Contatos contato)
        {
            if (contatos.Any(c => c.Nome == contato.Nome))
            {
                Console.WriteLine("Contato com esse nome já está na agenda.");
                return false;
            }

            contatos.Add(contato);
            return true;
        }

        public void ListarContatos()
        {
            Console.WriteLine("Contatos:");
            foreach (var contato in contatos)
            {
                Console.WriteLine($" - {contato.Nome} | {contato.Telefone}");
            }
            Console.WriteLine($"Total de contatos: {QuantidadeDeContatos}");
        }

        public int QuantidadeDeContatos { get { return contatos.Count; } }

    }
}
