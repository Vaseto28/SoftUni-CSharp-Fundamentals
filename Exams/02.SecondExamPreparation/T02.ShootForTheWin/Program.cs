using System;
using System.Linq;

namespace T02._Shoot_for_the_win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command;
            var shotTargets = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                var currIndex = int.Parse(command);
                if (currIndex >= 0 && currIndex < targets.Length)
                {
                    var currTarget = targets[currIndex];
                    targets[currIndex] = -1;
                    shotTargets++;
                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] == -1)
                        {
                            continue;
                        }
                        else
                        {
                            if (targets[i] > currTarget)
                            {
                                targets[i] -= currTarget;
                            }
                            else
                            {
                                targets[i] += currTarget;
                            }
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
            Console.Write($"Shot targets: {shotTargets} -> ");
            Console.Write(String.Join(" ", targets));
        }
    }
}
