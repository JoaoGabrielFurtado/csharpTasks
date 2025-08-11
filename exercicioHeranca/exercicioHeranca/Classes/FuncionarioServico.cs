using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal class FuncionarioServico
    {
        public string nome;
        public string departamento;
        public FuncionarioServico(string nome, string departamento)
        {
            this.nome = nome;
            this.departamento = departamento;
        }
    }
}
