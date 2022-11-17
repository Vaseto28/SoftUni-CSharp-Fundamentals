using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in banList)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
