using System;
using System.Collections.Generic;

namespace T05.SoftuniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> usersNumbersPairs = new Dictionary<string, string>();

            int users = int.Parse(Console.ReadLine());
            for (int i = 1; i <= users; i++)
            {
                string command = Console.ReadLine();
                string[] info = command.Split(' ');
                string action = info[0];
                if (action == "register")
                {
                    string username = info[1];
                    string licensePlateNumber = info[2];

                    if (usersNumbersPairs.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        continue;
                    }

                    usersNumbersPairs.Add(username, licensePlateNumber);
                    Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    continue;
                }
                else if (action == "unregister")
                {
                    string username = info[1];
                    if (!usersNumbersPairs.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                        continue;
                    }

                    usersNumbersPairs.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                    continue;
                }
            }

            foreach (var user in usersNumbersPairs)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
