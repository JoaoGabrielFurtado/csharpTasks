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