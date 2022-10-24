using System;

namespace multiplication_table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());
            if (multiplier > 10)
            {
                Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
            }
            else
            {
                for (multiplier = multiplier; multiplier <= 10; multiplier++)
                {
                    Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");

                }
            }
        }
    }
}
