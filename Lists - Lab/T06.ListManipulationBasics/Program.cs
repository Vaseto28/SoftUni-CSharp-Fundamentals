using System;
using System.Collections.Generic;
using System.Linq;

namespace T06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] arguments = command.Split();
                var arg1 = arguments[0];
                switch (arg1)
                {
                    case "Add":
                        var numberToAdd = int.Parse(arguments[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        var numberToRemove = int.Parse(arguments[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        var indexToRemoove = int.Parse(arguments[1]);
                        numbers.RemoveAt(indexToRemoove);
                        break;
                    case "Insert":
                        var numberToInsert = int.Parse(arguments[1]);
                        var indexToInsert = int.Parse(arguments[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
