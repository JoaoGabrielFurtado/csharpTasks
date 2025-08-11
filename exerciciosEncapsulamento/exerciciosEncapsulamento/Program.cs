using exerciciosEncapsulamento.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosEncapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region class Veiculo
            Veiculo veiculo = new Veiculo("ABC-1234");
            Console.WriteLine("Veículo: " + veiculo.Placa);
            Console.WriteLine("Velocidade atual: " + veiculo.Velocidade + " km/h\n");

            veiculo.AtualizarVelocidade(72.5);

            Console.WriteLine("Veículo: " + veiculo.Placa);
            Console.WriteLine("Velocidade atual: " + veiculo.Velocidade + " km/h");
            #endregion

            #region class Avaliacao

            Avaliacao avaliacao = new Avaliacao("Carla Silva");
            avaliacao.AtribuirNota(11);
            avaliacao.AtribuirNota(10);

            #endregion

            #region class Paciente e class HistoricoMedico

            Paciente paciente = new Paciente("Luiz Costa", 42);
            HistoricoMedico historico = new HistoricoMedico("XPT-9987");
            historico.ExibirCodigo();

            #endregion

            #region class Produto

            Projeto projeto = new Projeto("Lista da Laise");
            projeto.AdicionarTarefa("Criar tela de login");
            projeto.AdicionarTarefa("Implementar banco de dados");
            projeto.AdicionarTarefa("Limpar a casa");
            projeto.ExibirTarefas();

            #endregion

            #region class ContaBancaria e class SegurancaConta

            ContaBancaria conta = new ContaBancaria("Carlos Silva", 2500);
            conta.Sacar(1500); // inválido
            conta.Sacar(800);  // válido

            #endregion

            #region class Contato e class Agenda  

            Agenda agenda = new Agenda("Marina Souza");
            agenda.AdicionarContato(new Contatos("Carlos", "11998887777"));
            agenda.AdicionarContato(new Contatos("Carlos", "11991112222")); // duplicado
            agenda.AdicionarContato(new Contatos("Julia", "21988776655"));
            agenda.ListarContatos();

            #endregion

            #region class Hospede / class Quarto / class Reserva

            Hospede hospede = new Hospede("Juliana Moura");
            Quarto quarto = new Quarto(101);
            quarto.ValorDiaria = 250;

            Reserva reserva = new Reserva(hospede, quarto, 3);

            Console.WriteLine("Reserva para: " + reserva.Hospede.Nome);
            Console.WriteLine("Quarto: " + reserva.Quarto.Numero);
            Console.WriteLine("Valor total: R$ " + reserva.ValorTotal.ToString("F2"));

            #endregion
        }
    }
}
