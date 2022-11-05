using System;

namespace T05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //"coffee", "water", "coke", "snacks"
            var product = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            PriceOfProduct(product, quantity);
        }

        static void PriceOfProduct(string product, int quantity)
        {
            switch (product)
            {
                case "coffee":
                    var priceOfCoffee = 1.50 * quantity;
                    Console.WriteLine($"{priceOfCoffee:f2}");
                    break;
                case "water":
                    var priceOfWater = 1.00 * quantity;
                    Console.WriteLine($"{priceOfWater:f2}");
                    break;
                case "coke":
                    var priceOfCoke = 1.40 * quantity;
                    Console.WriteLine($"{priceOfCoke:f2}");
                    break;
                case "snacks":
                    var priceOfSnacks = 2.00 * quantity;
                    Console.WriteLine($"{priceOfSnacks:f2}");
                    break;
            }
        }
    }
}
