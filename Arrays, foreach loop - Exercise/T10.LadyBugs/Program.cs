using System;
using System.Linq;

namespace P10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugsIndexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] ladybugsInTheField = new int[fieldSize];
            for (int index = 0; index < ladybugsInTheField.Length; index++)
            {
                if (ladybugsIndexes.Contains(index))
                {
                    ladybugsInTheField[index] = 1;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                int initialIndex = int.Parse(cmdArgs[0]);
                string direction = cmdArgs[1];
                int flyLength = int.Parse(cmdArgs[2]);

                if (initialIndex < 0 || initialIndex >= ladybugsInTheField.Length)
                {
                    continue;
                }

                if (ladybugsInTheField[initialIndex] == 0)
                {
                    continue;
                }

                ladybugsInTheField[initialIndex] = 0;

                int nextIndex = initialIndex;
                while (true)
                {
                    if (direction == "right")
                    {
                        nextIndex += flyLength;
                    }
                    else if (direction == "left")
                    {
                        nextIndex -= flyLength;
                    }

                    if (nextIndex < 0 || nextIndex >= ladybugsInTheField.Length)
                    {
                        break;
                    }

                    if (ladybugsInTheField[nextIndex] == 0)
                    {
                        break;
                    }
                }

                if (nextIndex >= 0 && nextIndex < ladybugsInTheField.Length)
                {
                    ladybugsInTheField[nextIndex] = 1;
                }
            }

            Console.WriteLine(String.Join(" ", ladybugsInTheField));
        }
    }
}