using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosEncapsulamento.Classes
{
    public class Reserva
    {
        private int diarias;
        public Hospede Hospede { get; }
        public Quarto Quarto { get; }
        public double ValorTotal { get { return Quarto.ValorDiaria * diarias; } }

        public Reserva(Hospede h, Quarto q, int d)
        {
            Hospede = h;
            Quarto = q;
            diarias = d;
        }
    }
}
