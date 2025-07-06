using ByteBankIO;
using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {

        string enderecoDoArquivo = "contas.txt";


        // O Using é utilizado para tratar automaticamente possíveis erros no início do FileStream (caso ele seja
        // nulo por exemplo). 
        using (FileStream fluxoDoArquivo = new FileStream(enderecoDoArquivo, (FileMode)3))
        {
            int numeroDeBytesLidos = -1;


            var buffer = new byte[1024];

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                Console.Write($"\nBytes Lidos {numeroDeBytesLidos}\n");

                EscreverBuffer(buffer, numeroDeBytesLidos);
            }

            fluxoDoArquivo.Close(); // sempre necessário utilizar o close para que garanta que o sistema reconheça
            // o fechamento da aplicação

            Console.ReadKey();
        }

        /*
         * Exemplo de erro - falta de LOOP (o que caso o arquivo tivesse mais de 1024bytes (1KB) tornaria 
         * incompleta a leitura) / também, dentro do arquivo de texto, existe um caractere "ó" que, dentro da 
         * tabela ASCII, é incapaz de ser lido, precisaria ser pela tabela UNICODE
        var fs = new FileStream("teste.txt", FileMode.Open);

        var buffer = new byte[1024];
        var encoding = Encoding.ASCII;

        var bytesLidos = fs.Read(buffer, 0, 1024);
        var conteudoArquivo = encoding.GetString(buffer, 0, bytesLidos);

        Console.Write(conteudoArquivo);
        */
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {

        var utf8 = new UTF8Encoding();

        // É importante que durante o uso do método GetString definasse os parâmetras de maneira correta, limitando
        // o máximo de bytes que ele lerá, para que não gere repetições. O método funciona com 3 parâmetros
        // (o buffer que será convetido, o ínicio, e até onde ele lerá). Por conta desse funcionamento definesse que
        // o método lerá até o numero de BytesLidos, para não gerar repetições.
        string texto = utf8.GetString(buffer, 0, bytesLidos);
        Console.Write(texto);

        /*
        foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }
        */

    }

}