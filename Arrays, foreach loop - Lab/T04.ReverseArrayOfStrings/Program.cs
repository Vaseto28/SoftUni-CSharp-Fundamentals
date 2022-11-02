using System;
using System.Linq;

namespace T04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split();
            Array.Reverse(items);
            Console.WriteLine(String.Join(" ", items));
        }
    }
}
