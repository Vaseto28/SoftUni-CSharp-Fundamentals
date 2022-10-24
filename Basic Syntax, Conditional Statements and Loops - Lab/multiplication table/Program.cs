using System;

namespace multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
        }
    }
}
