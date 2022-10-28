using System;

namespace _08.Town_info
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine();
            var population = uint.Parse(Console.ReadLine());
            var area = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
        }
    }
}
