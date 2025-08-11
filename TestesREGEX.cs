using System.Text.RegularExpressions;
using System;

public class ChavePix
{
    public static void Main(string[] args)
    {
        Console.Write("Digite a chave PIX: ");
        string chavePix = Console.ReadLine();

        string padraoCPF = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";
        string padraoCNPJ = @"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$";
        string padraoTelefone = @"^\(\d{2}\)\d{5}-\d{4}$";
        string padraoEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        string tipoChave;

        if (Regex.IsMatch(chavePix, padraoCPF))
            tipoChave = "CPF";
        else if (Regex.IsMatch(chavePix, padraoCNPJ)) 
            tipoChave = "CNPJ";
        else if (Regex.IsMatch(chavePix, padraoTelefone))
            tipoChave = "Telefone";
        else if (Regex.IsMatch(chavePix, padraoEmail))
            tipoChave = "E-mail";
        else
            tipoChave = "Formato inválido";

        Console.WriteLine($"Tipo da chave PIX: {tipoChave}");
    }
}

/*
         .	Caractere, exceto quebra de linha
        \d	Dígito (0-9)
        \D	Caractere que não é um dígito
        \w	Caractere alfanumérico
        \W	Caractere não alfanumérico
        \s	Espaço em branco
        \S	Caractere que não é espaço em branco
        ^	Início da string
        $	Fim da string

        *	0 ou mais ocorrências do padrão anterior
        +	1 ou mais ocorrências do padrão anterior
        ?	0 ou 1 ocorrência do padrão anterior
        {n}	Exatamente n ocorrências do padrão anterior
        {n,}	n ou mais ocorrências do padrão anterior
        {n,m}	Entre n e m ocorrências do padrão anterior

        [abc]	Qualquer caractere dentro dos colchetes ('a', 'b' ou 'c')
        [^abc]	Qualquer caractere exceto os que não estejam dentro dos colchetes
        [a-z]	Qualquer caractere minúsculo de 'a' a 'z'
        [A-Z]	Qualquer caractere maiúsculo de 'A' a 'Z'
        [0-9]	Qualquer dígito
        [a-zA-Z]	Qualquer letra maiúscula ou minúscula

        IsMatch()	Verifica se um padrão existe na string.
        Match()	Retorna a primeira correspondência do padrão.
        Matches()	Retorna todas as correspondências do padrão.
        Replace()	Substitui ocorrências do padrão por uma nova string.
        Split()	Divide uma string com base em um padrão.

*/