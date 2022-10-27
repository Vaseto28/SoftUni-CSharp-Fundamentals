using System;

namespace _01.Meters_to_kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var meters = int.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000.0M;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
