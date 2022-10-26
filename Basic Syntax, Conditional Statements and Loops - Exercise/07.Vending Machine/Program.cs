using System;

namespace _07.Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sumOfMoney = 0.0;
            while (input != "Start")
            {
                var money = double.Parse(input);
                if (money != 0.1 && money != 0.2 && money != 0.5 && money != 1 && money != 2)
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                else
                {
                    sumOfMoney += money;
                }
                input = Console.ReadLine();
            }
            var totalMoney = sumOfMoney;
            var change = 0.0;
            while (input != "End")
            {
                input = Console.ReadLine();
                var snacks = input;
                switch (snacks)
                {
                    default:
                        if (snacks != "End")
                        {
                            Console.WriteLine("Invalid product");
                        }
                        continue;
                    case "Nuts":
                        if (sumOfMoney >= 2.0)
                        {
                            sumOfMoney -= 2.0;
                            Console.WriteLine("Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            change = sumOfMoney;

                        }
                        break;
                    case "Water":
                        if (sumOfMoney >= 0.7)
                        {
                            sumOfMoney -= 0.7;
                            Console.WriteLine("Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            change = sumOfMoney;
                        }
                        break;
                    case "Crisps":
                        if (sumOfMoney >= 1.5)
                        {
                            sumOfMoney -= 1.5;
                            Console.WriteLine("Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            change = sumOfMoney;
                        }
                        break;
                    case "Soda":
                        if (sumOfMoney >= 0.8)
                        {
                            sumOfMoney -= 0.8;
                            Console.WriteLine("Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            change = sumOfMoney;
                        }
                        break;
                    case "Coke":
                        if (sumOfMoney >= 1.0)
                        {
                            sumOfMoney -= 1.0;
                            Console.WriteLine("Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            change = sumOfMoney;
                        }
                        break;
                }
            }
            if (sumOfMoney > 0)
            {
                change = sumOfMoney;
                Console.WriteLine($"Change: {change:f2}");
            }
            else
            {
                change = Math.Abs(sumOfMoney);
                Console.WriteLine($"Change: {change:f2}");
            }
        }
    }
}
