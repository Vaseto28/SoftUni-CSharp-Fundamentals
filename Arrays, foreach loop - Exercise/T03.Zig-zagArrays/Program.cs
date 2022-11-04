using System;
using System.Linq;

namespace T03.Zig_zagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var iterations = int.Parse(Console.ReadLine());
            int[] array1 = new int[iterations];
            int[] array2 = new int[iterations];
            for (int i = 1; i <= iterations; i++)
            {
                int[] currArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (i % 2 != 0)
                {
                    array1[i - 1] = currArray[0];
                    array2[i - 1] = currArray[1];
                }
                else
                {
                    array1[i - 1] = currArray[1];
                    array2[i - 1] = currArray[0];
                }
            }
            Console.WriteLine(String.Join(" ", array1));
            Console.WriteLine(String.Join(" ", array2));
        }
    }
}
