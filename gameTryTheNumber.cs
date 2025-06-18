using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_jogoAdivinharNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int verifica = 0;

            void Logo1()
            {
                Console.WriteLine(@"
█▓▒▒░░░JOGO DO ADIVINHA░░░▒▒▓█
                    ");

                Console.WriteLine("\nInstruções:");
                Console.WriteLine("Digite SAIR para fechar o programa.");
                Console.WriteLine("\nAcerte o número entre 1 e 100. Valendo!");


            }
            void Logo2()
            {
                Console.WriteLine(@"
█▓▒▒░░░JOGO DO ADIVINHA░░░▒▒▓█
                    ");

            }
            void Game()
            {

                Random random = new Random();
                int numero = random.Next(1, 101);

                int exit = 0;

                int tentativas = 1;

                do
                {
                    Console.Clear();
                    Logo1();
                    Console.Write("Seu palpite: ");
                    string palpite = Console.ReadLine();


                    if (palpite.ToLower() == "sair")
                    {
                        Console.WriteLine("\n \n \nVocê saiu do jogo. Obrigado por Jogar");
                        break;
                    }

                    if (!int.TryParse(palpite, out int palpiteNumero))
                    {
                        Console.Clear();
                        Logo1();
                        Console.Write("Seu palpite deve ser um número ");
                        Thread.Sleep(1000);
                        continue;
                    }


                    if (palpiteNumero == numero)
                    {
                        Console.Clear();
                        Logo2();
                        string tentativasCorrigido = tentativas == 1 ? "tentativa" : "tentativas";
                        tentativas++;
                        Console.WriteLine($"\nParabéns, você acertou! O número secreto era {numero} e você acertou em {tentativas} {tentativasCorrigido}");
                        Thread.Sleep(1000);
                        Console.Write("\nPara jogar denovo digite (0),para sair digite (1): ");
                        int jogarDenovo = int.Parse(Console.ReadLine());
                        if(jogarDenovo == 0)
                        {
                            verifica = 0;
                        }
                        else
                        {
                            verifica = 1;
                        }
                            Thread.Sleep(4000);
                        exit = 1;
                    }
                    else
                    {
                        tentativas++;
                        string ajuda = palpiteNumero > numero ? "menor" : "maior";
                        Console.WriteLine($"O numero sorteado é {ajuda}");
                        Thread.Sleep(1000);
                    }

                } while (exit == 0);

            }

            do
            {
                Console.Clear();

                Logo2();

                Console.WriteLine("Bem Vindo ao Jogo do Adivinha, neste jogo você deve acertar um número aleatório entre 1 e 100");


                Console.WriteLine("\nInstruções:");
                Console.WriteLine("Digite SAIR para fechar o programa.");
                Console.Write("Digite INICIAR para começar: ");

                string inicio = Console.ReadLine();

                int verificaString = 0;

                if (inicio.ToLower() == "sair")
                {
                    Console.WriteLine("Fechando o programa. Aguarde...");
                    break;
                }
                else { 
                    do
                    {                     
                        switch (inicio.ToLower())
                        {

                            case "iniciar":
                                Game();
                                verificaString++;
                                break;
                            case "sair":
                                Console.WriteLine("Fechando o programa. Aguarde...");
                                verificaString++;
                                break;
                            default:
                                Console.WriteLine("Digite novamente");
                                Thread.Sleep(1500);
                                Console.Clear();
                                Logo2();
                                Console.WriteLine("Bem Vindo ao Jogo do Adivinha, neste jogo você deve acertar um número aleatório entre 1 e 100");
                                Console.WriteLine("\nInstruções:");
                                Console.WriteLine("Digite SAIR para fechar o programa.");
                                Console.Write("Digite INICIAR para começar: ");
                                break;
                        }
                        inicio = Console.ReadLine();
                    } while (verificaString == 0);
                }
            } while (verifica == 0);
            Console.ReadKey();

        }
    }
}
