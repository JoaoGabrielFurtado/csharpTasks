using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosEncapsulamento
{
    internal class Veiculo
    {
        public string Placa { get; }
        public double Velocidade { get; private set; }

        public Veiculo(string placa)
        {
            Placa = placa;
            Velocidade = 0;
        }

        public void AtualizarVelocidade(double novaVelocidade)
        {
            if(novaVelocidade > 0) { 
            Velocidade = novaVelocidade;
            }
        }
    }
}
