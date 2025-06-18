using System;
using System.Collections.Generic;

namespace ModeloRestaurante.Classes
{
    public class Cardapio
    {

        public static List<Cardapio> CardapioLista = new List<Cardapio>();

        public string NomeComida { get; set; }
        public int PrecoComida { get; set; }
        public int IdPrato { get; set; }

        public string CardapioCompleto => $"ID:{IdPrato}\nPrato: {NomeComida} / Preço {PrecoComida}";

        public Cardapio(string nomeComida, int precoComida, int idPrato)
        {
            NomeComida = nomeComida;
            PrecoComida = precoComida;
            IdPrato = idPrato;
        }

        public Cardapio() { }

        public static void MostrarCardapio() {
            Console.WriteLine("Menu:\n");
            foreach (var cardapio in CardapioLista)
            {
                Console.WriteLine($" - {cardapio.CardapioCompleto}\n");
            }
        }

        public static void PopularCardapio()
        {
            Cardapio cardapio1 = new Cardapio("Frango Parmegiana", 50, 100);
            Cardapio cardapio2 = new Cardapio("Feijoada", 60, 200);
            Cardapio cardapio3 = new Cardapio("Virada Paulista", 35, 300);

            CardapioLista.Add(cardapio1);
            CardapioLista.Add(cardapio2);
            CardapioLista.Add(cardapio3);

        }
    }
}
