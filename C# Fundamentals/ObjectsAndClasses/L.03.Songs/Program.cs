using System;
using System.Linq;
using System.Collections.Generic;

namespace L._03.Songs
{
    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine());
            List<Song> playlist = new List<Song>();

            for (int i = 0; i < numSongs; i++)
            {
                string[] currentData = Console.ReadLine().Split('_');
                string type = currentData[0];
                string name = currentData[1];
                string time = currentData[2];

                Song song = new Song(); // object

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                playlist.Add(song);
            }
            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (Song song in playlist)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in playlist)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
