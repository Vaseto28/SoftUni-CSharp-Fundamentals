using System;

namespace _06.Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstChar = char.Parse(Console.ReadLine());
            var secondChar = char.Parse(Console.ReadLine());
            var thirdChar = char.Parse(Console.ReadLine());
            Console.WriteLine($"{thirdChar} {secondChar} {thirdChar}");
        }
    }
}
