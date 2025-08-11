using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacaoDeserializacaoArquivos;

internal class Usuario
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }

    public Usuario(string nome, int idade, string email)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
    }

}
