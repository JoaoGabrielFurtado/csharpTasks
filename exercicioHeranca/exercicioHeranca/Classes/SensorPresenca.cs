using exercicioHeranca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal class SensorPresenca : ISensor
    {
        public void Ativar()
        {
            Console.WriteLine("Sensor de presença ativado.");
        }

        public void Desativar()
        {
            Console.WriteLine("Sensor de presença desativado.");
        }
    }
}
