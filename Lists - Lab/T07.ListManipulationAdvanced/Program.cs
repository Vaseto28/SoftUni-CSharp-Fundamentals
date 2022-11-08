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
            var hasBeenChanged = false;
            while (command != "end")
            {
                string[] arguments = command.Split();
                var arg1 = arguments[0];
                switch (arg1)
                {
                    case "Add":
                        var numberToAdd = int.Parse(arguments[1]);
                        numbers.Add(numberToAdd);
                        hasBeenChanged = true;
                        break;
                    case "Remove":
                        var numberToRemove = int.Parse(arguments[1]);
                        numbers.Remove(numberToRemove);
                        hasBeenChanged = true;
                        break;
                    case "RemoveAt":
                        var indexToRemoove = int.Parse(arguments[1]);
                        numbers.RemoveAt(indexToRemoove);
                        hasBeenChanged = true;
                        break;
                    case "Insert":
                        var numberToInsert = int.Parse(arguments[1]);
                        var indexToInsert = int.Parse(arguments[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        hasBeenChanged = true;
                        break;
                    case "Contains":
                        var numberToCheck = int.Parse(arguments[1]);
                        if (numbers.Contains(numberToCheck))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> evenNums = numbers.FindAll(evenNums => evenNums % 2 == 0);
                        Console.WriteLine(String.Join(" ", evenNums));
                        break;
                    case "PrintOdd":
                        List<int> oddNums = numbers.FindAll(oddNums => oddNums % 2 != 0);
                        Console.WriteLine(String.Join(" ", oddNums));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        var condition = arguments[1];
                        var numToCompare = int.Parse(arguments[2]);
                        Console.WriteLine(String.Join(" ", GetFilteredList(numbers, condition, numToCompare)));
                        break;
                }
                command = Console.ReadLine();
            }
            if (hasBeenChanged)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
            else
            {
                //Console.WriteLine(String.Join(" ", numbers));
            }
        }

        static List<int> GetFilteredList(List<int> numbers, string condition, int num)
        {
            switch (condition)
            {
                case "<":
                    List<int> smallerNums = numbers.FindAll(x => x < num);
                    return smallerNums;
                    break;
                case ">":
                    List<int> greaterNums = numbers.FindAll(x => x > num);
                    return greaterNums;
                    break;
                case "<=":
                    List<int> smallerOrEqualNums = numbers.FindAll(x => x <= num);
                    return smallerOrEqualNums;
                    break;
                case ">=":
                    List<int> GreaterOrEqualNums = numbers.FindAll(x => x >= num);
                    return GreaterOrEqualNums;
                    break;
            }

            return numbers;
        }
    }
}
