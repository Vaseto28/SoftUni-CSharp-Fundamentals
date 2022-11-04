using System;
using System.Linq;

namespace T07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var sequenceCounter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                var currNum = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    var nextNum = array[j];
                    if (currNum != nextNum)
                    {
                        sequenceCounter = 0;
                        break;
                    }
                    else
                    {
                        sequenceCounter++;
                        Console.Write($"{currNum} ");
                    }
                }
            }
        }
    }
}
