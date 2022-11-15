using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.Orders
{
    class Product
    {
        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            string command;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] productInfo = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = productInfo[0];
                double price = double.Parse(productInfo[1]);
                int quantity = int.Parse(productInfo[2]);

                bool isAlreadyInTheList = false;
                foreach (var product in products)
                {
                    if (product.Name == name)
                    {
                        isAlreadyInTheList = true;
                        product.Price = price;
                        product.Quantity += quantity;
                        break;
                    }
                }
                if (isAlreadyInTheList)
                {
                    continue;
                }

                Product newProduct = new Product(name, price, quantity);
                products.Add(newProduct);
            }

            Dictionary<string, double> productPricePairs = new Dictionary<string, double>();

            for (int i = 0; i < products.Count; i++)
            {
                double totalPrice = products[i].Price * products[i].Quantity;
                productPricePairs.Add(products[i].Name, totalPrice);
            }

            foreach (var product in productPricePairs)
            {
                Console.WriteLine($"{product.Key} -> {product.Value:f2}");
            }
        }
    }
}
