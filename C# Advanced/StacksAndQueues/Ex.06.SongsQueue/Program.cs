using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songsSequence = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> playlist = new Queue<string>(songsSequence);

            while (playlist.Any())
            {
                string commandData = Console.ReadLine();

                if (commandData == "Play")
                {
                    playlist.Dequeue();
                }
                else if (commandData.Contains("Add"))
                {
                    //string songToAdd = commandData.Replace("Add", string.Empty).TrimStart();//V01
                    string songToAdd = commandData.Substring(4, commandData.Length - 4);//V02

                    if (!CheckForDuplicate(playlist, songToAdd))
                    {
                        playlist.Enqueue(songToAdd);
                    }
                    else
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                }
                else if (commandData == "Show")
                {
                    Console.WriteLine(string.Join(", ", playlist));
                }
            }

            Console.WriteLine("No more songs!");
        }

        static bool CheckForDuplicate(Queue<string> songsPlaylist, string specificSong)
        {
            return songsPlaylist.Contains(specificSong);
        }
    }
}
