using System;
using System.Collections.Generic;

namespace T03.House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>();
            var commands = int.Parse(Console.ReadLine());
            for (int i = 0; i < commands; i++)
            {
                var command = Console.ReadLine();
                string[] arguments = command.Split();
                if (arguments.Length == 3)
                {
                    var name = arguments[0];
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else if (arguments.Length == 4)
                {
                    var name = arguments[0];
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            Console.WriteLine(String.Join(Environment.NewLine, guests));
        }
    }
}
