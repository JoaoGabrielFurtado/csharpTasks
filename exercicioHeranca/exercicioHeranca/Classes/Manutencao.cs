using exercicioHeranca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal class Manutencao : IServico
    {

        public string tarefa;
        public FuncionarioServico funcionario;
        public Manutencao(string tarefa, FuncionarioServico funcionario)
        {
            this.tarefa = tarefa;
            this.funcionario = funcionario;
        }
        public void ExecutarServico()
        {
            Console.WriteLine($"Executando serviço de manutenção: {tarefa}");
            Console.WriteLine($"Responsável: {funcionario.nome} - Departamento: {funcionario.departamento}\n");
        }

    }
}
