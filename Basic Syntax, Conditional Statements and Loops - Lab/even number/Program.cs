using System;

namespace even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            while (number % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                if (number % 2 == 0)
                {
                    break;
                }
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {Math.Abs(number)}");
        }
    }
}
