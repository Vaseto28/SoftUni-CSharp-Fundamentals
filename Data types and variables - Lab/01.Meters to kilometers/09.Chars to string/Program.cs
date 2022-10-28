using System;

namespace _09.Chars_to_string
{
    class Program
    {
        static void Main(string[] args)
        {
            var char1 = char.Parse(Console.ReadLine());
            var char2 = char.Parse(Console.ReadLine());
            var char3 = char.Parse(Console.ReadLine());
            Console.WriteLine($"{char1}{char2}{char3}");
        }
    }
}
