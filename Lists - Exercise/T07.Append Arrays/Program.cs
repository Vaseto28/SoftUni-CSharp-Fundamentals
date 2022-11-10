using System;
using System.Collections.Generic;
using System.Linq;

namespace T07.Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> output = new List<string>();
            var input = Console.ReadLine();
            string[] arrayOfInput = input.Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = arrayOfInput.Length - 1; i >= 0; i--)
            {
                string[] currArray = arrayOfInput[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                output.AddRange(currArray);
            }

            Console.WriteLine(String.Join(" ", output));
        }
    }
}
