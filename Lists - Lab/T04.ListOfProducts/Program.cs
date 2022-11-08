using System;
using System.Collections.Generic;

namespace T04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            var productsCount = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < productsCount; i++)
            {
                string currProduct = Console.ReadLine();
                products.Add(currProduct);
            }
            products.Sort();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
