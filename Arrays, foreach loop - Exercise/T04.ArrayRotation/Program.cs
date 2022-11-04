using System;
using System.Linq;

namespace T04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rotations = int.Parse(Console.ReadLine());
            for (int currRotation = 1; currRotation <= rotations; currRotation++)
            {
                int firstElement = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    array[i - 1] = array[i];
                }
                array[array.Length - 1] = firstElement;
            }
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
