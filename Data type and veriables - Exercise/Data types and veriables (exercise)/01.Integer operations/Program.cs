using System;

namespace _01.Integer_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());
            var fourthNum = int.Parse(Console.ReadLine());

            long sum = (long)firstNum + secondNum;
            long quotient = sum / thirdNum;
            long multiplicationProduct = quotient * fourthNum;

            Console.WriteLine(multiplicationProduct);
        }
    }
}
