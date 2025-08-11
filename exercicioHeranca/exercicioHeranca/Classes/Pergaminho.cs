using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal class Pergaminho : ItemDigital
    {

        public string conteudo;

        public Pergaminho(string t, string conteudo)  : base (t)
        {
            this.conteudo = conteudo;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Detalhes do Pergaminho:\nTítulo: {titulo}\nConteúdo: {conteudo}");
        }

    }
}
