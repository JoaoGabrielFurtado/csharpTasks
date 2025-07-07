using System;
using System.IO;
using System.Text;

internal class CopiadorTXT
{
    static void Main(string[] args)
    {
        string arquivoAntigo = "TXT_ORIGINAL.txt";
        string arquivoNovo = "TXT_COPIA.txt";

        using (FileStream fs = new FileStream(arquivoAntigo, FileMode.Open))
        using (FileStream fs2 = new FileStream(arquivoNovo, FileMode.Create))
        {
            byte[] buffer = new byte[1024];
            Encoding encoding = Encoding.UTF8;
            int bytesLidos = -1;

            while (bytesLidos != 0)
            {
                bytesLidos = fs.Read(buffer, 0, 1024);

                fs2.Write(decodificaNovamente, 0, bytesLidos);
            }

            string line = "\n";
            byte[] quebraLinha = encoding.GetBytes(line);
            fs2.Write(quebraLinha, 0, quebraLinha.Length);

            byte[] rodape = encoding.GetBytes("Cópia do arquivo TXT_ORIGINAL.txt");
            fs2.Write(rodape, 0, rodape.Length);
        }

        Console.WriteLine("Arquivo Copiado");
    }
}
