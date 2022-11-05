using System;

namespace T04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                PrintingOneLine(i);
            }
            for (int i = num; i >= 1; i--)
            {
                PrintingOneLine(i);
            }
        }

        static void PrintingOneLine(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
