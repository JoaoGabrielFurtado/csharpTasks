using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciadorSupermercadoBasicoPOO
{
    internal class Program
    {
        internal class ProdutoEstoque
        {

            List<ProdutoEstoque> listaProdutos = new List<ProdutoEstoque>();

            public string Nome { get; set; }
            public int Preco { get; set; }
            public int Estoque { get; set; }
            public string ProdCompleto => $"Produto: {Nome}\n Preço: {Preco}\n Quantidade em Estoque: {Estoque}\n\n";

            //$"Produto: {Nome}\n Preço: {Preco}\n Quantidade em Estoque: {Estoque}";

            public void AdicionarProduto(ProdutoEstoque produto)
            {
                listaProdutos.Add(produto);
            }

            public void ExibirProduto()
            {
                foreach (ProdutoEstoque produto in listaProdutos)
                {
                    Console.WriteLine(produto.ProdCompleto);
                }
            }

        }

        static void Main(string[] args)
        {

            ProdutoEstoque produto = new ProdutoEstoque();

            void TelaInicial()
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção: \n Digite (1) para Adicionar Produtos \n Digite (2) para Mostrar todos os Produtos");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        AdicionarProdutos();
                        break;
                    case "2":
                        MostrarProdutos();
                        break;
                    default:
                        Console.WriteLine("\n Selecione uma opção válida");
                        TelaInicial();
                        break;
                }
            }

            void AdicionarProdutos()
            {
                ProdutoEstoque produtoParaAdicionar = new ProdutoEstoque();
                Console.Clear();
                string produtoNome;
                while (true)
                {
                    Console.Clear();
                    Console.Write("Produto: ");
                    produtoNome = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(produtoNome))
                        break;

                    Console.WriteLine("Escreva um nome válido.");
                    Thread.Sleep(2000);
                }
                produtoParaAdicionar.Nome = produtoNome;

                string produtoPreco;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Produto: {produtoNome}");
                    Console.Write("Preço: ");
                    produtoPreco = Console.ReadLine();

                    if (int.TryParse(produtoPreco, out int pPreco))
                    {
                        produtoParaAdicionar.Preco = pPreco;
                        break;
                    }

                    Console.WriteLine("Escreva um número válido.");
                    Thread.Sleep(2000);
                }

                string produtoEstoque;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Produto: {produtoNome}");
                    Console.WriteLine($"Preço: {produtoPreco}");
                    Console.Write("Estoque: ");
                    produtoEstoque = Console.ReadLine();

                    if (int.TryParse(produtoEstoque, out int pEstoque))
                    {
                        produtoParaAdicionar.Estoque = pEstoque;
                        break;
                    }

                    Console.WriteLine("Escreva um número válido.");
                    Thread.Sleep(2000);
                }

                produto.AdicionarProduto(produtoParaAdicionar);
                Console.WriteLine("Produto salvo com sucesso!");
                Thread.Sleep(3000);
                TelaInicial();

            }

            void MostrarProdutos()
            {
                Console.Clear();
                produto.ExibirProduto();
                Console.ReadKey();
                TelaInicial();
            }

            TelaInicial();

        }
    }
}
