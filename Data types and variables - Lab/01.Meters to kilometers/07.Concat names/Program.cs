using System;

namespace _07.Concat_names
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var secondName = Console.ReadLine();
            var delimeter = Console.ReadLine();
            Console.WriteLine($"{name}{delimeter}{secondName}");
        }
    }
}
