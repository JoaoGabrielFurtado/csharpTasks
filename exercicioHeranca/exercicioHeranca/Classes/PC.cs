using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal class PC
    {

        public PlacaMae placaMae;
        public Processador processador;

        public PC(PlacaMae pm, Processador p)
        {
            placaMae = pm;
            processador = p;
        }
        public void ExibirConfiguracao()
        {
            Console.WriteLine("Computador configurado com:");
            Console.WriteLine($"Processador: {processador.marca} - {processador.modelo}");
            Console.WriteLine($"Placa-mãe: {placaMae.fabricante} - {placaMae.socket}");
        }

    }
}
