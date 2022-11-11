using System;
using System.Collections.Generic;

namespace T03.Songs
{
    class Songs
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public double Time { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var numberOfSongs = int.Parse(Console.ReadLine());
            List<Songs> songs = new List<Songs>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                var command = Console.ReadLine();
                string[] songParams = command.Split('_', StringSplitOptions.RemoveEmptyEntries);
                var typeList = songParams[0];
                var name = songParams[1];
                Songs currSong = new Songs
                {
                    TypeList = typeList,
                    Name = name
                };
                songs.Add(currSong);
            }

            var lastCommand = Console.ReadLine();

            if (lastCommand == "all")
            {
                foreach (var songName in songs)
                {
                    Console.WriteLine(songName.Name); 
                }
            }
            else
            {
                List<Songs> filteredSongs = songs.FindAll(songType => songType.TypeList == lastCommand);
                foreach (var songName in filteredSongs)
                {
                    Console.WriteLine(songName.Name);
                }
            }
        }
    }
}
