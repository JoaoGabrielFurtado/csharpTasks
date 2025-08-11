using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal class ClienteVIP : Pessoa
    {
        public string NivelFidelidade { get; set; }
        public string CodigoVIP { get; set; }

        public ClienteVIP(string n, int i, string nf, string cb ) : base (n, i)
        {
            NivelFidelidade = nf;
            CodigoVIP = cb;
        }

    }
}
