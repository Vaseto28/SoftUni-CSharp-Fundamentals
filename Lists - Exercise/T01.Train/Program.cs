using System;
using System.Linq;
using System.Collections.Generic;

namespace T01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passangers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacityOfTheWagoons = int.Parse(Console.ReadLine());
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split().ToArray();
                if (arguments.Length == 2)
                {
                    var newWagoonPassangers = int.Parse(arguments[1]);
                    passangers.Add(newWagoonPassangers);
                }
                else if (arguments.Length == 1)
                {
                    var newPassangers = int.Parse(arguments[0]);
                    for (int i = 0; i < passangers.Count; i++)
                    {
                        if (newPassangers + passangers[i] <= capacityOfTheWagoons)
                        {
                            passangers[i] += newPassangers;
                            break;
                        }
                        else if (i == passangers.Count)
                        {
                            passangers.Add(newPassangers);
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ", passangers));
        }
    }
}
