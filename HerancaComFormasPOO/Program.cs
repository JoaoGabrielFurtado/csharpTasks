using desafiosPOOAlura.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoHerancaComFormas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, Forma> dic = new Dictionary<int, Forma>();

            Console.WriteLine("Calculador de Área e Perímetro\n\nEscolha uma das opções\n[1] Quadrado\n[2] Triângulo (Equilatero)\n[3] Círculo");
            Console.Write("Sua escolha: ");
            int escolha = int.Parse(Console.ReadLine());

            string choose = " ";

            if (escolha == 1) choose = "Quadrado";
            if (escolha == 2) choose = "Triangulo";
            if (escolha == 3) choose = "Circulo";

            Console.Clear();
            Console.WriteLine($"Digite [1] para calcular a área ou [2] para calcular o perímetro\n");
            Console.Write("Sua escolha: ");
            int escolha2 = int.Parse(Console.ReadLine());

            double escolha3;

            //perimetros
            if (escolha2 == 2 && (escolha == 1 || escolha == 2))
            {
                Console.Clear();
                Console.WriteLine($"Perímetro do {choose}");
                Console.Write($"Digite os LADOS do {choose}: ");
                escolha3 = double.Parse(Console.ReadLine());
                if (escolha == 1) dic.Add(escolha, new Quadrado(escolha3));
                if (escolha == 2) dic.Add(escolha, new Triangulo(escolha3));
                dic[escolha].CalculaPerimetro();
            }
            if (escolha2 == 2 && escolha == 3)
            {
                Console.Clear();
                Console.WriteLine($"Perímetro do {choose}");
                Console.Write($"Digite o RAIO do {choose}: ");
                escolha3 = double.Parse(Console.ReadLine());
                dic.Add(escolha, new Circulo(escolha3));
                dic[escolha].CalculaPerimetro();
            }

            //areas
            if (escolha2 == 1 && escolha == 1)
            {
                Console.Clear();
                Console.WriteLine($"Área do {choose}");
                Console.Write($"Digite os LADOS do {choose}: ");
                escolha3 = double.Parse(Console.ReadLine());
                dic.Add(escolha, new Quadrado(escolha3));
                dic[escolha].CalculaArea();
            }
            if (escolha2 == 1 && escolha == 2)
            {
                Console.Clear();
                Console.WriteLine($"Área do {choose}");
                Console.Write($"Digite a BASE do {choose}: ");
                escolha3 = double.Parse(Console.ReadLine());
                Console.Write($"Digite a ALTURA do {choose}: ");
                double alturaTriangulo = double.Parse(Console.ReadLine());
                dic.Add(escolha, new Triangulo(escolha3, alturaTriangulo));
                dic[escolha].CalculaArea();
            }
            if (escolha2 == 1 && escolha == 3)
            {
                Console.Clear();
                Console.WriteLine($"Área do {choose}");
                Console.Write($"Digite o RAIO do {choose}: ");
                escolha3 = double.Parse(Console.ReadLine());
                dic.Add(escolha, new Circulo(escolha3));
                dic[escolha].CalculaArea();
            }

            Console.ReadKey();
        }
    }
}
