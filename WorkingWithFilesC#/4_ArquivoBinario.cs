using ByteBankIO;
using System.Text;

partial class Program
{
    static void EscritaBinaria()
    {

        using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
        using (var escritor = new BinaryWriter(fs))
        {
            escritor.Write(456);      // numero da Agencia
            escritor.Write(546544);   // numero da Conta
            escritor.Write(4000.50);  // Saldo
            escritor.Write("João Gabriel");
        }
        
    }

    static void LeituraBinaria()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
        using (var leitor = new BinaryReader(fs))
        {
            var agencia = leitor.ReadUInt32();
            var numeroConta = leitor.ReadUInt32();
            var saldo = leitor.ReadUInt32();
            string titular = leitor.ReadString();

            Console.WriteLine($"AG {agencia} , Numero Conta {numeroConta}, Saldo {saldo} ---- TITULAR {titular}");
        }
    }

}