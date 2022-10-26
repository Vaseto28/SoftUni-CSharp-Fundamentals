using System;

namespace _11.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = int.Parse(Console.ReadLine());
            var finalPrice = 0.0;
            var pricePerOrder = 0.0;
            for (int i = 1; i <= orders; i++)
            {
                var pricePerCapsule = double.Parse(Console.ReadLine());
                var days = int.Parse(Console.ReadLine());
                var capsules = int.Parse(Console.ReadLine());
                pricePerOrder = (days * capsules) * pricePerCapsule;
                finalPrice += pricePerOrder;
                Console.WriteLine($"The price for the coffee is: ${pricePerOrder:f2}");
                pricePerOrder = 0.0;
            }
            Console.WriteLine($"Total: ${finalPrice:f2}");
        }
    }
}
