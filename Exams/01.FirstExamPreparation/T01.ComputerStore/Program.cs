using System;

namespace T01._Computer_store
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine();
            var sum = (decimal)0.0;
            var regularOrder = false;
            var specialOrder = false;
            if (commands == "regular")
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            else if (commands == "special")
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            while (commands != "regular" || commands != "special")
            {
                var currPrice = decimal.Parse(commands);
                if (currPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    sum += currPrice;
                }


                commands = Console.ReadLine();
                if (commands == "regular")
                {
                    regularOrder = true;
                    break;
                }
                else if (commands == "special")
                {
                    specialOrder = true;
                    break;
                }
            }

            if (sum == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {sum:f2}$");
            Console.WriteLine($"Taxes: {sum * 0.20m:f2}$");
            Console.WriteLine("-----------");
            var totalPrice = sum + sum * 0.20m;
            if (regularOrder)
            {
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
            else if (specialOrder)
            {
                var totalPriceWithDiscount = totalPrice - totalPrice * 0.10m;
                Console.WriteLine($"Total price: {totalPriceWithDiscount:f2}$");
            }
        }
    }
}
