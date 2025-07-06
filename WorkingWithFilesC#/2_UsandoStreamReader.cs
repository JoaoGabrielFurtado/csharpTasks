using ByteBankIO;
using System.Text;

partial class Program
{
    static void UsandoStreamReader()
    {
        string enderecoDoArquivo = "contas.txt";
        using (FileStream fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            StreamReader leitor = new StreamReader(fluxoDeArquivo);

            // string linha = leitor.ReadLine();  - Lê apenas uma linha do arquivo

            // string texto = leitor.ReadToEnd();  - Carrega o arquivo de uma única vez, o que pode ser prejucidial
            // para a otimização de um programa. Para arquivos maiores é interessante utilizar um buffer para 
            // carregar por partes

            // string numero = leitor.Read()  - Retorna o primeiro byte do arquivo (numericamente)

            // O EndOfStream retorna um BOOL (true) caso a leitura tenha terminado e (false) caso ainda tenha oq ler
            while (!leitor.EndOfStream)
            {
                string linha = leitor.ReadLine();
                ContaCorrente contaCorrente = ConverteStringParaContaCorrente(linha);

                string msg = $"{contaCorrente.Titular.Nome} : Conta número {contaCorrente.Numero} / Agência {contaCorrente.Agencia} / Saldo {contaCorrente.Saldo}\n";
                Console.WriteLine(msg);
                Console.ReadKey();
            }


        }
        Console.ReadKey();
    }

    static ContaCorrente ConverteStringParaContaCorrente(string linha)
    {
        // 375 4644 2483.13 Jonatan

        // o metodo Split retorna um array de strings intevalando uma string inteira através do parâmetro passado 
        string[] campos = linha.Split(',');

        string agencia = campos[0];
        string numero = campos[1];
        string saldo = campos[2].Replace(".", ",");
        string nomeTitular = campos[3];

        int agenciaComInt = int.Parse(agencia);
        int numeroComInt = int.Parse(numero);
        double saldoComDouble = Convert.ToDouble(saldo);

        Cliente titular = new Cliente();
        titular.Nome = nomeTitular;

        ContaCorrente resultado = new ContaCorrente(agenciaComInt, numeroComInt);
        resultado.Depositar(saldoComDouble);
        resultado.Titular = titular;

        return resultado;
    }

}