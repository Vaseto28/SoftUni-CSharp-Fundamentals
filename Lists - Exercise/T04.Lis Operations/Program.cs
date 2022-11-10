using System;
using System.Linq;
using System.Collections.Generic;

namespace T04.List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split().ToArray();
                var action = arguments[0];
                switch (action)
                {
                    case "Add":
                        var numberToAdd = int.Parse(arguments[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Insert":
                        var numberToInsert = int.Parse(arguments[1]);
                        var indexToInsert = int.Parse(arguments[2]);
                        if (indexToInsert >= 0 && indexToInsert < numbers.Count)
                        {
                            numbers.Insert(indexToInsert, numberToInsert);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        break;
                    case "Remove":
                        var indexToRemove = int.Parse(arguments[1]);
                        if (indexToRemove >= 0 && indexToRemove < numbers.Count)
                        {
                            numbers.RemoveAt(indexToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        break;
                    case "Shift":
                        var direction = arguments[1];
                        if (direction == "left")
                        {
                            var shifts = int.Parse(arguments[2]);
                            for (int i = 0; i < shifts; i++)
                            {
                                var firstNum = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(firstNum);
                            }
                        }
                        else
                        {
                            var shifts = int.Parse(arguments[2]);
                            for (int i = 0; i < shifts; i++)
                            {
                                var lastNum = numbers[numbers.Count - 1];
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Insert(0, lastNum);
                            }
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
