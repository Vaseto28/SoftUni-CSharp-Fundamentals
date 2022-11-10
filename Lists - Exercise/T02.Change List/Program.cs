using System;
using System.Linq;
using System.Collections.Generic;

namespace T02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split().ToArray();
                var action = arguments[0];
                switch (action)
                {
                    case "Delete":
                        var elementsToDelete = int.Parse(arguments[1]);
                        numbers.RemoveAll(x => x == elementsToDelete);
                        break;
                    case "Insert":
                        var element = int.Parse(arguments[1]);
                        var index = int.Parse(arguments[2]);
                        numbers.Insert(index, element);
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
