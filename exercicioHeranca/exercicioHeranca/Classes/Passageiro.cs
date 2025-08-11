using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca.Classes
{
    internal class Passageiro : Pessoa
    {

        public int quantidadeBilhetes;

        public Passageiro(string n, int i, int q) : base(n, i){
            quantidadeBilhetes = q;
        }

        public void MostrarDadosPassageiro()
        {
            Console.WriteLine($"Passageiro: {Nome} - Idade: {Idade} - Bilhetes: {quantidadeBilhetes} ");
        }

    }
}
