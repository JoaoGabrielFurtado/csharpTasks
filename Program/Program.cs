using ModeloRestaurante.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ModeloRestaurante
{
    
    internal class Program
    {

        public static void MostrarMesa(Restaurante restaurante) 
        {
            restaurante.MostrarMesa();
            Console.ReadKey();
        }

        public static void EscolherMesa(Restaurante restaurante)
        {
            string resultado = restaurante.EscolherMesa();
            Console.WriteLine(resultado);
            Thread.Sleep(2000);
        }

        public static void MostrarCardapio(Restaurante restaurante)
        {
            Console.Clear();
            restaurante.MostrarCardapio();
        }

        public static void FazerPedido(Restaurante restaurante)
        {
            restaurante.FazerPedido();
            Thread.Sleep(2000);
        }

        public static void DesocuparMesa(Restaurante restaurante)
        {
            string resultado = restaurante.DesocuparMesa();
            Console.WriteLine(resultado);
            Thread.Sleep(2000);
        }

        public static void VerPedidos(Restaurante restaurante)
        {
            restaurante.VerPedidos();
        }

        static void Main(string[] args)
        {
            var program = new Program();

            Restaurante restaurante = new Restaurante();

            Mesa mesa1 = new Mesa(1);
            Mesa mesa2 = new Mesa(2);
            Mesa mesa3 = new Mesa(3);

            Cardapio.PopularCardapio();

            restaurante.mesas.Add(mesa1);
            restaurante.mesas.Add(mesa2);
            restaurante.mesas.Add(mesa3);

            string escolha;

            do
            {
                Console.Clear();
                Console.WriteLine("Bem-Vindo ao Restaurante Cucaratchia");
                Console.WriteLine("\nEscolha uma das opções\n");

                Console.Write("[1] Mesas Disponíveis\n[2] Escolher Mesa\n[3] Ver Cardápio\n[4] Fazer Pedido\n[5] Verificar Pedidos\n" +
                    "[6] Desocupar Mesa\n[7] Fechar Programa\nSua Escolha: ");
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        MostrarMesa(restaurante);
                        break;
                    case "2":
                        EscolherMesa(restaurante);
                        break;
                    case "3":
                        MostrarCardapio(restaurante);
                        break;
                    case "4":
                        FazerPedido(restaurante);
                        break;
                    case "5":
                        VerPedidos(restaurante);
                        break;
                    case "6":
                        DesocuparMesa(restaurante);
                        break;
                    case "7":
                        break;

                }
            } while (escolha != "7");

        }
    }
}
