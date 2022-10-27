using System;

namespace _02.Paunds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var paunds = double.Parse(Console.ReadLine());
            decimal dollars = (decimal)(paunds * 1.31);
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
