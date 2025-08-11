using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosEncapsulamento.Classes
{
    internal class Projeto
    {

        List<string> tarefas = new List<string>();
        private int quantidade = 0;

        public string Nome { get; set; }

        public Projeto(string nomeProduto)
        {
            Nome = nomeProduto;
        }

        public void AdicionarTarefa(string tarefa)
        {
            if(tarefa.Length > 0) { 
            tarefas.Add(tarefa);
            quantidade++;
            }
        }

        public void ExibirTarefas()
        {
            Console.WriteLine($"Projeto: {Nome}");
            Console.WriteLine("Tarefas:");
            foreach(var t in tarefas)
            {
                Console.WriteLine($" - {t}");
            }
            Console.WriteLine($"Quantidade de tarefas: {QuantidadeTarefas}");
        }

        public int QuantidadeTarefas { get { return quantidade; } }

    }
}
