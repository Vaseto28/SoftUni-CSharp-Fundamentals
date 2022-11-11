using System;
using System.Numerics;

namespace T02.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            BigInteger factorialOfTheNumber = 1;
            for (int i = 1; i <= num; i++)
            {
                factorialOfTheNumber *= i;
            }
            Console.WriteLine(factorialOfTheNumber);
        }
    }
}
