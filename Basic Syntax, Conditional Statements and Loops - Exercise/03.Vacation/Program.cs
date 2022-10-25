using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var day = Console.ReadLine();
            double price = people;
            if (type == "Business" && people >= 100)
            {
                price -= 10;
            }
            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price *= 8.45;
                            break;
                        case "Saturday":
                            price *= 9.80;
                            break;
                        case "Sunday":
                            price *= 10.46;
                            break;
                    }
                    if (people >= 30)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price *= 10.90;
                            break;
                        case "Saturday":
                            price *= 15.60;
                            break;
                        case "Sunday":
                            price *= 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price *= 15;
                            break;
                        case "Saturday":
                            price *= 20;
                            break;
                        case "Sunday":
                            price *= 22.50;
                            break;
                    }
                    if (people >= 10 && people <= 20)
                    {
                        price -= price * 0.05;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
