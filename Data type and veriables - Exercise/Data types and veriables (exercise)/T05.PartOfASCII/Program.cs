using System;

namespace T05.PartOfASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                var currChar = (char)i;
                Console.Write($"{currChar} ");
            }
        }
    }
}
