using System;

namespace T04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i <= chars; i++)
            {
                var symbol = char.Parse(Console.ReadLine());
                sum += symbol;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
