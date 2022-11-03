using System;

namespace T02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine().Split();
            var array2 = Console.ReadLine().Split();
            foreach (var item in array2)
            {
                foreach (var item1 in array1)
                {
                    if (item == item1)
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
        }
    }
}
