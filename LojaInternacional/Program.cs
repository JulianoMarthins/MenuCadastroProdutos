using LojaInternacional.entities;
using System;
using System.Collections.Generic;

namespace LojaInternacional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> produto = new List<Product>();

            Console.Write("Número de cadastros: ");
            int num = int.Parse(Console.ReadLine());


            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("\nSelecione o tipo do produto:\n\nProduto Nacional -> 'n'\n" +
                    "Produto Seminovo: -> 'u'\nProduto Importado -> 'i'");

                Console.Write("\nDigite sua opção: ");
                char op = char.Parse(Console.ReadLine().ToLower());

                Console.WriteLine($"\nCadastro do {i + 1}° Produto:\n");
                Console.Write("Nome do produto: ");
                string name = Console.ReadLine();

                Console.Write("Preço do produto: ");
                double price = double.Parse(Console.ReadLine());


                switch (op)
                {
                    case 'n':
                        produto.Add(new Product(name, price));                        
                        break;

                    case 'u':                        
                        produto.Add(new UsedProduct(name, price));                        
                        break;

                    case 'i':
                        Console.Write("Impostos: ");
                        double imposto = double.Parse(Console.ReadLine());

                        produto.Add(new ImportedProduct(imposto, name, price));                        
                        break;

                    default:
                        Console.WriteLine("Você digitou um valor inválido.");
                        i--;
                        break;
                }
            }

            Console.WriteLine("\n\nLista de preços: \n");

            foreach (var item in produto)
            {
                Console.WriteLine(item.PriceTag() + "\n");

            }

        }
    }
}
