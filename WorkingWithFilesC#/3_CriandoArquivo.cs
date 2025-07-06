using ByteBankIO;
using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (FileStream fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            string contaComoString = "456, 7895, 4621.21, João Gabriel";
            Encoding encoding = Encoding.UTF8;

            byte[] bytes = encoding.GetBytes(contaComoString);

            // o método Write escreve dentro do arquivo, diferente do Read que apenas lê o que esta escrito
            fluxoDeArquivo.Write(bytes, 0, bytes.Length);

            Console.WriteLine("Arquivo Criado");
        }
    }

    // Assim como na leitura de um arquivo temos um método que encurta o código (StreamReader), para escrever em um arquivo também temos um método
    // que facilita e encurta a escrita no código, o StreamWriter. O método abaixo mostra um pouco do uso desse método.

    static void CriarArquivoComWriter()
    {
        string caminhoNovoArquivo = "contasExportadas.csv";
        string stg = "Minha piroca imensa";

        // efetuamos verificação (para evitar erros) com using na criação das duas variáveis
        using (FileStream fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (StreamWriter escritor = new StreamWriter(fluxoDeArquivo))
        {
            // em vez de usar o fluxoDeArquivo usamos o escritor pois ele é a variável que corresponde a StreamWriter
            escritor.Write(stg);

        }

        Console.WriteLine("Arquivo Criado");
    }

    static void TestaEscrita()
    {
        string caminho = "Prototipo.txt";

        using (FileStream fluxoDeArquivo = new FileStream(caminho, FileMode.Create))
        using (StreamWriter escritor = new StreamWriter(fluxoDeArquivo))
        {
            for(int i = 0; i < 100000; i++)
            {
                escritor.WriteLine($"Linha {i}");

                // quando estamos enviando texto para ser escrito no arquivo, isso pode ser uma ação um tanto quanto demorada para o processamento.
                // Para sanar essa intervalo longo entre a leitura e a escrita no arquivo podemos usar o método FLUSH(), que automaticamente envia
                // o que deve ser impresso no arquivo de TXT para o FileStream e é impresso de maneira mais rápida, evitando um monte de processos que
                // precisariam ser processados antes da impressão.
                escritor.Flush();

                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle ENTER.");
                Console.ReadKey();
            }
        }
    }

}