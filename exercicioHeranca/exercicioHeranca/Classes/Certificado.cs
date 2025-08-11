using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal class Certificado
    {

        private Profissao profissao;

        public Certificado(Profissao p) 
        {
            profissao = p;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Certificado emitido para: {profissao.titulo}");
        }

    }
}
