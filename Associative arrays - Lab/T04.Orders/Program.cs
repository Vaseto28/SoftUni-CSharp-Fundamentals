using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.Orders
{
    class Product
    {
        public Product(string name, decimal price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>();
            Dictionary<string, decimal> productsAndPrices = new Dictionary<string, decimal>();

            string command;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] information = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = information[0];
                decimal price = decimal.Parse(information[1]);
                int quantity = int.Parse(information[2]);

                Product newProduct = new Product(name, price, quantity);

                if (products.Any(newProduct => newProduct.Name == name))
                {
                    newProduct.Quantity += quantity;
                    newProduct.Price = price;
                }

                products.Add(newProduct);
            }

            foreach (var product in products)
            {
                decimal totalPriceOfAProduct = product.Price * product.Quantity;
                productsAndPrices.Add(product.Name, totalPriceOfAProduct);
            }

            foreach (var product in productsAndPrices)
            {
                Console.WriteLine($"{product.Key} -> {product.Value:f2}");
            }
        }
    }
}
