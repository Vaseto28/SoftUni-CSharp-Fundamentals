using System;
using System.Linq;

namespace T08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var magicSum = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                var firstNum = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    var secondNum = array[j];
                    if (firstNum + secondNum == magicSum)
                    {
                        Console.Write($"{firstNum} {secondNum}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
