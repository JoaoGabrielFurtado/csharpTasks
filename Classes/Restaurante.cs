using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ModeloRestaurante.Classes
{
    public class Restaurante
    {
        public List<Mesa> mesas = new List<Mesa>();
        List<Pedido> pedidos = new List<Pedido>();
        
        public void MostrarMesa()
        {
            Console.Clear();
            List<Mesa> mesasOcupadas = mesas.Where(m => m.EstaOcupada).ToList();
            List<Mesa> mesasLivres = mesas.Where(m => !m.EstaOcupada).ToList();

            if (mesasLivres.Count > 0)
            {
                Console.Write($"Mesas Disponíveis:");
                foreach (var mesa in mesasLivres)
                { Console.Write($" Mesa-{mesa.NumeroMesa} "); }
            } else
            {
                Console.WriteLine("Não temos mesas disponíveis");
            }

            if (mesasOcupadas.Count > 0)
            {
                Console.Write($"\nMesas Ocupadas:");
                foreach (var mesa in mesasOcupadas)
                { Console.Write($" Mesa-{mesa.NumeroMesa} "); }
            }
            else
            {
                Console.WriteLine("\nNão temos mesas ocupadas");
            }

            Console.WriteLine("\nAperte qualquer tecla para retornar");
        }
        public string EscolherMesa()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma mesa vazia (Por favor digite o número da mesa)\n");
            List<Mesa> mesasDisponiveis = mesas.Where(m => !m.EstaOcupada).ToList();
            Console.Write($"Mesas Disponíveis:");
            foreach (var mesa in mesasDisponiveis)
            {
                Console.Write($" Mesa-{mesa.NumeroMesa}");
            }
            Console.Write("\nDigite o número da mesa: ");
            string escolha = Console.ReadLine();

            if (!int.TryParse(escolha, out int escolhida))
                return "Não foi possível reservar a mesa, por favor digite uma opção válida";

            Mesa mesaEscolhida = mesasDisponiveis.FirstOrDefault(m => m.NumeroMesa == escolhida);

            if (mesaEscolhida != null)
            {
                mesaEscolhida.EstaOcupada = true;
                return $"Você escolheu a Mesa-{mesaEscolhida.NumeroMesa}";       
            }
            else
            {
                return "Mesa não encontrada ou já ocupada.";
            }


        }
        public string DesocuparMesa()
        {
            Console.Clear();
            Console.WriteLine("Escolha qual mesa deseja desocupar");
            List<Mesa> mesasOcupadas = mesas.Where(m => m.EstaOcupada).ToList();
            Console.Write($"Mesas Ocupadas:");
            foreach (var mesa in mesasOcupadas)
            {
                Console.Write($" Mesa-{mesa.NumeroMesa}");
            }
            Console.Write("\nQual mesa deseja desocupar (Digitar o número da mesa): ");
            string escolha = Console.ReadLine();
            if (!int.TryParse(escolha, out int escolhida))
                return "Não foi possível desocupar a mesa, por favor digite uma opção válida";

            Mesa mesaEscolhida = mesasOcupadas.FirstOrDefault(m => m.NumeroMesa == escolhida);

            if(mesaEscolhida != null)
            {
                mesaEscolhida.EstaOcupada = false;
                return $"Mesa-{mesaEscolhida.NumeroMesa} foi desocupada";
            }
            else
            {
                return "Mesa não encontrada ou já desocupada.";
            }

        }
        public void MostrarCardapio()
        {
            Cardapio.MostrarCardapio();
            Console.WriteLine("Aperte qualquer tecla para voltar");
            Console.ReadKey();
        }   
        public string FazerPedido()
        {
            Console.Clear();
            Console.Write("Qual o ID do pedido: ");
            string escolhaId = Console.ReadLine();
            if (!int.TryParse(escolhaId, out int escolhaIdInt))
                return "Insira um número válido";

            List<Cardapio> CardapioList = Cardapio.CardapioLista;

            if (!CardapioList.Any(p => p.IdPrato == escolhaIdInt))
            {
                Console.WriteLine($"O prato com ID {escolhaIdInt} não existe no cardápio.\nSelecione a opção 3 para ver o Menu");
                Thread.Sleep(2000);
                return " ";          
            }

            Cardapio pratoEscolhido = CardapioList.FirstOrDefault(p => p.IdPrato == escolhaIdInt);

            if (pratoEscolhido == null)
            {
                Console.WriteLine("Erro ao localizar o prato. Tente novamente.");
                Thread.Sleep(2000);
                return " ";
            }

            Console.Write("Qual a mesa que você está sentado (número da mesa): ");
            string escolhaMesa = Console.ReadLine();
            if (!int.TryParse(escolhaMesa, out int escolhaMesaInt))
                return "Insira um número válido";

            Mesa mesaOcupada = mesas.FirstOrDefault(m => m.NumeroMesa == escolhaMesaInt);

            if(mesaOcupada == null || mesaOcupada.EstaOcupada == false)
            {
                Console.WriteLine($"Mesa {mesaOcupada.NumeroMesa} está vazia.\nFavor reservá-la");
                Thread.Sleep(2000);
                return " ";
            }

            Pedido pedido = new Pedido();
            pedido.NumeroMesa = escolhaMesaInt;
            pedido.NomePedido = pratoEscolhido.NomeComida;

            pedidos.Add(pedido);
            
            Console.WriteLine("Pedido realizado com sucesso! ");
            Thread.Sleep(2000);
            return " ";

        }
        public void VerPedidos()
        {
            Console.Clear();

            if (pedidos.Count == 0) {  
                Console.WriteLine("Nenhum pedido no momento");
                Thread.Sleep(2000);
                return; 
            }

            foreach (Pedido p in pedidos)
            {
                Console.WriteLine(p.PedidoCompleto + "\n");
            }

            Console.WriteLine("\nAperte uma tecla para sair.");
            Console.ReadKey();

        }
    }
}
