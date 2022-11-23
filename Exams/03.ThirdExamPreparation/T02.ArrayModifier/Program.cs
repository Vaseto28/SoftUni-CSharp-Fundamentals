using System;
using System.Linq;

namespace T02.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var action = arguments[0];
                switch (action)
                {
                    case "swap":
                        var firstIndexToSwap = int.Parse(arguments[1]);
                        var secondIndexToSwap = int.Parse(arguments[2]);
                        var firstElement = numbers[firstIndexToSwap];
                        numbers[firstIndexToSwap] = numbers[secondIndexToSwap];
                        numbers[secondIndexToSwap] = firstElement;
                        break;
                    case "multiply":
                        var firstIndexToMultiply = int.Parse(arguments[1]);
                        var secondIndexToMultiply = int.Parse(arguments[2]);
                        var product = numbers[firstIndexToMultiply] * numbers[secondIndexToMultiply];
                        numbers[firstIndexToMultiply] = product;
                        break;
                    case "decrease":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i]--;
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
