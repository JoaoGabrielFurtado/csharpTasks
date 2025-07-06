using ByteBankIO;
using System.Text;

partial class Program
{
    static void StreamsDaConsole()
    {

        string nomeArquivo = "testada.txt";

        using (var fluxoDeEntrada = Console.OpenStandardInput()) // Lê o que o usuário digita no Console
        using (var fluxoDeArquivo = new FileStream(nomeArquivo, FileMode.Create))
        {
            byte[] buffer = new byte[1024];

            while (true)
            {
                int bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);

                fluxoDeArquivo.Write(buffer, 0, bytesLidos);
                fluxoDeArquivo.Flush();

                Console.WriteLine($"Mensagem escrita no arquivo {nomeArquivo}");
                Console.WriteLine($"Bytes lidos na console: {bytesLidos}");
            }



        }        
    }

}