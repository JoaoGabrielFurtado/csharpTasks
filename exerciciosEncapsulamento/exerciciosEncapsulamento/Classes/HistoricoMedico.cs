using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosEncapsulamento.Classes
{
    internal class HistoricoMedico
    {
        public string CodigoProntuario { get; }

        public HistoricoMedico(string codigoProntuario)
        {
            CodigoProntuario = codigoProntuario;
        }
        public void ExibirCodigo()
        {
            Console.WriteLine($"Código: {CodigoProntuario}");
        }
    }
}
