using System;
using System.Linq;
using System.Collections.Generic;

namespace T03.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command;
            var mooves = 0;
            while ((command = Console.ReadLine()) != "end")
            {
                //Getting the indexes
                mooves++;
                int[] indexes = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var firstIndex = indexes[0];
                var secondIndex = indexes[1];

                //Validating the indexes
                if (firstIndex == secondIndex || firstIndex < 0 || firstIndex >= elements.Count || secondIndex < 0 || secondIndex >= elements.Count)
                {
                    elements.Insert(elements.Count / 2, $"-{mooves}a");
                    elements.Insert(elements.Count / 2, $"-{mooves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }

                //Getting the elements and see if they are matching or not
                var firstElement = elements[firstIndex];
                var secondElement = elements[secondIndex];
                if (firstElement == secondElement)
                {
                    if (firstIndex > secondIndex)
                    {
                        elements.RemoveAt(firstIndex);
                        elements.RemoveAt(secondIndex);
                    }
                    else
                    {
                        elements.RemoveAt(secondIndex);
                        elements.RemoveAt(firstIndex);
                    }
                    Console.WriteLine($"Congrats! You have found matching elements - {firstElement}!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                //Checking if the player guessed all the elements before gigving the "end" command
                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {mooves} turns!");
                    return;
                }
            }

            //Printing the messages for loses
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", elements));
        }
    }
}
