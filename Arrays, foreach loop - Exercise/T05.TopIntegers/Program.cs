using System;
using System.Linq;

namespace T05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                var currElement = array[i];
                var isTopInteger = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    var nextElement = array[j];
                    if (nextElement >= currElement)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write($"{currElement} ");
                }
            }
        }
    }
}
