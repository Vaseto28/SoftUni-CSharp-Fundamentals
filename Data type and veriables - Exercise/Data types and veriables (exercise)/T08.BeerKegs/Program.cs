using System;

namespace T08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var kegs = int.Parse(Console.ReadLine());
            var biggestValue = 0.0;
            var theBiggestKeg = String.Empty;
            for (int i = 0; i < kegs; i++)
            {
                var model = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());
                var currValue = Math.PI * radius * radius * height;
                if (currValue > biggestValue)
                {
                    biggestValue = currValue;
                    theBiggestKeg = model;
                }
            }
            Console.WriteLine(theBiggestKeg);
        }
    }
}
