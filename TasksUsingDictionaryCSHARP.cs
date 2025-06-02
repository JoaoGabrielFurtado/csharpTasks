using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Dictionary#01

            /*
            Dictionary<string, List<double>> Alunos = new Dictionary<string, List<double>>();

            Alunos.Add("João", new List<double>{ 7, 6.5, 9 });

            Console.WriteLine("Notas do João:");
            foreach (double notas in Alunos["João"])
            {
                Console.WriteLine(notas);
            }
            */

            //Dictionary#02

            /*
            Dictionary<string, int> Produtos = new Dictionary<string, int>();

            Produtos.Add("Lapis", 10);
            Produtos.Add("Borracha", 15);
            Produtos.Add("Caneta", 25);
            Produtos.Add("Apontador", 5);
            Produtos.Add("Caderno", 30);

            Console.WriteLine("Verificador de quantidade em Estoque");
            Console.WriteLine("\nProdutos:");
            foreach (string produto in Produtos.Keys)
            {
                Console.WriteLine($"{produto}");
            }

            Console.Write("\nDigite o nome do Produto que deseja saber a quantidade: ");
            string nomeProduto = Console.ReadLine();
            if (Produtos.ContainsKey(nomeProduto))
            {
                Console.WriteLine($"\nExistem {Produtos[nomeProduto]} unidades de {nomeProduto} no estoque.");
            }
            else
            {
                Console.WriteLine("\nProduto não encontrado no estoque.");
            }
            */

            //Dictionary#03

            /*
            Dictionary<string, string> Quiz = new Dictionary<string, string>();

            Quiz.Add("Vênus", "Vênus");
            Quiz.Add("1500", "1500");
            Quiz.Add("13", "13");
            Quiz.Add("Hélio", "Hélio");

            void Cabeçalho()
            {
                Console.WriteLine("Jogo do Quiz");
                Console.WriteLine("Responda com a palavra correta\n");
            }
            

            Pergunta01();

            void Pergunta01()
            {
                Console.Clear();
                Cabeçalho();

                Console.WriteLine("Pergunta 01\n");

                Console.WriteLine("Qual é o planeta mais próximo do Sol?");
                Console.WriteLine("\nA) Terra\r\nB) Vênus\r\nC) Mercúrio\r\nD) Marte");
                Console.Write("Sua resposta: ");
                string resposta = Console.ReadLine();
                if (Quiz.ContainsKey(resposta))
                {
                    Console.WriteLine("Você acertou");
                    Thread.Sleep(1000);
                    Pergunta02();
                }
                else
                {
                    Console.WriteLine("Você errou");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Cabeçalho();
                    Pergunta01();
                }
            }

            void Pergunta02()
            {
                Console.Clear();
                Cabeçalho();

                Console.WriteLine("Pergunta 02\n");

                Console.WriteLine("Em que ano o Brasil foi oficialmente descoberto pelos portugueses?");
                Console.WriteLine("\nA) 1500\r\nB) 1492\r\nC) 1822\r\nD) 1889");
                Console.Write("Sua resposta: ");
                string resposta = Console.ReadLine();
                if (Quiz.ContainsKey(resposta))
                {
                    Console.WriteLine("Você acertou");
                    Thread.Sleep(1000);
                    Pergunta03();
                }
                else
                {
                    Console.WriteLine("Você errou");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Cabeçalho();
                    Pergunta02();
                }
            }

            void Pergunta03()
            {
                Console.Clear();
                Cabeçalho();

                Console.WriteLine("Pergunta 03\n");

                Console.WriteLine("Qual é o resultado da expressão: 3 × (2 + 4) − 5?");
                Console.WriteLine("\nA) 13\r\nB) 15\r\nC) 12\r\nD) 11");
                Console.Write("Sua resposta: ");
                string resposta = Console.ReadLine();
                if (Quiz.ContainsKey(resposta))
                {
                    Console.WriteLine("Você acertou");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Pergunta04();
                }
                else
                {
                    Console.WriteLine("Você errou");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Cabeçalho();
                    Pergunta03();
                }
            }

            void Pergunta04()
            {
                Console.Clear();
                Cabeçalho();

                Console.WriteLine("Pergunta 04\n");

                Console.WriteLine("Qual desses elementos químicos é um gás nobre?");
                Console.WriteLine("\nA) Oxigênio\r\nB) Nitrogênio\r\nC) Hélio\r\nD) Carbono");
                Console.Write("Sua resposta: ");
                string resposta = Console.ReadLine();
                if (Quiz.ContainsKey(resposta))
                {
                    Console.WriteLine("Você acertou");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Parabéns, você finalizou o jogo! Obrigado por Jogar.");
                }
                else
                {
                    Console.WriteLine("Você errou");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Cabeçalho();
                    Pergunta04();
                }
            }

            */

            //Dictionary#04

            /*
            void PreencherNomeComAsteriscos(string nome)
            {
                int longe = nome.Length;
                string ast = string.Empty.PadLeft(longe, '*');
                Console.WriteLine(ast);
                Console.WriteLine(nome);
                Console.WriteLine(ast + "\n");
            }

            Dictionary<string, string> Usuario = new Dictionary<string, string>();
            Dictionary<string, string> Senha = new Dictionary<string, string>();

            Usuario.Add("admin", "admin");
            Senha.Add("admin", "admin");

            Inicio();

            void Inicio()
            {
                Console.Clear();
                PreencherNomeComAsteriscos("Bem-Vindo ao Login/Register");
                Console.WriteLine("Escolha uma das opções: \n");
                Console.WriteLine("Digite LOGIN para se Logar");
                Console.WriteLine("Digite REGISTRAR para se Registrar\n");
                Console.Write("Escolha sua opção: ");
                string escolha = Console.ReadLine();

                if(escolha.Trim().ToLower() == "login")
                {
                    Console.Clear();
                    Login();
                    
                } else if (escolha.Trim().ToLower() == "registrar")
                {
                    Console.Clear();
                    Registrar();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Por Favor selecione uma das duas opções.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Inicio();
                }
            }

            void Login()
            {
                Console.Clear();
                PreencherNomeComAsteriscos("Opção Login");

                Console.Write("Usuário: ");
                string usuario = Console.ReadLine();
                Console.Write("Senha: ");
                string senha = Console.ReadLine();

                if (Usuario.ContainsKey(usuario) && Senha.ContainsKey(senha))
                {
                    Console.Clear();
                    Console.WriteLine("Você está Logado");
                } else
                {
                    Console.WriteLine("\nUsuário não encontrado Por Favor Registre-se");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Inicio();
                }
            }

            void Registrar()
            {
                Console.Clear();
                PreencherNomeComAsteriscos("Opção Registrar");

                Console.Write("Digite um nome de usuário: ");
                string usuario = Console.ReadLine();
                Console.Write("Digite uma senha: ");
                string senha = Console.ReadLine();

                if (Usuario.ContainsKey(usuario) || Senha.ContainsKey(senha))
                {                
                    Console.WriteLine("\nUsuario ou Senha ja existentes");
                    Thread.Sleep(5000);
                    Inicio();
                }
                else
                {
                    try
                    {
                        Usuario.Add(usuario, usuario);
                        Senha.Add(senha, senha);
                        Console.WriteLine("Usuario e Senha salvos com sucesso! favor logar-se");
                        Thread.Sleep(4000);
                        Inicio();
                    }
                    catch (Exception ex) { Console.WriteLine("Erro ao registrar Usuário"); }
                }
            }
            */

        }
    }
}
