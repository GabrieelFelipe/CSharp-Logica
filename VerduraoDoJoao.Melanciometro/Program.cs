using System;

namespace VerduraoDoJoao.Melanciometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Matriz de produtos
            string[,] produtos = new string[2, 3] { { "Melancia Comum", "5.50", "1" }, { "Melancia Baby", "8.56", "2" } };

            // Contador de produtos
            int numProdutos = 2;

            Console.WriteLine("Escolha um produto:");

            // Exibir produtos existentes
            for (int i = 0; i < numProdutos; i++)
            {
                Console.WriteLine($"{produtos[i, 2]} - {produtos[i, 0]} ({produtos[i, 1]})");
            }

            // Opção de adicionar novo produto
            Console.WriteLine($"{numProdutos + 1} - Adicionar novo produto");

            // Ler opção do usuário
            int op = int.Parse(Console.ReadLine());

            // Verificar se o usuário escolheu adicionar um novo produto
            if (op == numProdutos + 1)
            {
                Console.WriteLine("Digite as informações do novo produto:");

                // Ler informações do novo produto
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preço: ");
                string preco = Console.ReadLine();

                // Adicionar novo produto à matriz
                
                produtos[numProdutos, 0] = nome;
                produtos[numProdutos, 1] = preco;
                produtos[numProdutos, 2] = (numProdutos + 1).ToString();

                numProdutos++;
            }
            else if (op >= 1 && op <= numProdutos)
            {
                // Exibir produto escolhido
                Console.WriteLine($"Você escolheu: {produtos[op - 1, 0]} ({produtos[op - 1, 1]})");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

            Console.ReadKey();
        }
    }
}
