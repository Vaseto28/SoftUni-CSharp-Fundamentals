using System;

namespace _11.Refactor_volume_of_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            var length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            var width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            var height = double.Parse(Console.ReadLine());
            var V = (length * width * height) / 3;
            Console.Write($"Pyramid Volume: {V:f2}");

        }
    }
}
