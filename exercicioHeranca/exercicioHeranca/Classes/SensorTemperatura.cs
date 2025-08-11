using exercicioHeranca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal class SensorTemperatura : ISensor
    {
        public void Ativar()
        {
            Console.WriteLine("Sensor de temperatura ativado."); 

        }
        public void Desativar()
        {
            Console.WriteLine("Sensor de temperatura desativado."); 
        }

    }
}
