using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace desafiosPOOAlura.Classes
{
    public class Forma
    {
        public virtual void CalculaPerimetro()
        {
            Console.Clear();
            Console.WriteLine("Calculando perímetro...");
            Thread.Sleep(2000);
        }

        public virtual void CalculaArea()
        {
            Console.Clear();
            Console.WriteLine("Calculando área...");
            Thread.Sleep(2000);
        }
    }

    public class Quadrado : Forma
    {
        private double Lado { get; set; }

        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public override void CalculaPerimetro()
        {
            // L * 4
            base.CalculaPerimetro();
            var perimetro = Lado * 4;
            Console.WriteLine($"O perímetro do Quadrado de lados {Lado} é de {perimetro}");
        }
        public override void CalculaArea()
        {
            // L * L
            base.CalculaArea();
            var area = Lado * Lado;
            Console.WriteLine($"A área do Quadrado de lados {Lado} é de {area}");
        }
    }

    public class Triangulo : Forma
    {

        private double Lado { get; set; }
        private double Base { get; set; }
        private double Altura { get; set; }
        public Triangulo(double lado)
        {
            Lado = lado;
        }

        public Triangulo(double baseT, double altura)
        {
            Base = baseT;
            Altura = altura;
        }

        public override void CalculaPerimetro()
        {
            // L * 3
            base.CalculaPerimetro();
            var perimetro = Lado * 3;
            Console.WriteLine($"O perímetro do Triângulo de lados {Lado} é de {perimetro}");
        }
        public override void CalculaArea()
        {
            // B * A / 2
            base.CalculaArea();
            var area = (Base * Altura) / 2;
            Console.WriteLine($"A área do Triângulo de BASE={Base} e ALTURA={Altura} é de {area}");
        }
    }

    public class Circulo : Forma
    {
        private double Raio { get; set; }
        private double pi = Math.PI;

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public override void CalculaPerimetro()
        {
            // 2pi * r
            base.CalculaPerimetro();
            var perimetro = (2 * pi) * Raio;
            Console.WriteLine($"O perímetro do Ciculo de RAIO {Raio} é de {perimetro}");
        }
        public override void CalculaArea()
        {
            // pi * r^2
            base.CalculaArea();
            var area = pi * (Raio * Raio);
            Console.WriteLine($"A área do Circulo de RAIO {Raio} é de {area}");
        }
    }
}
