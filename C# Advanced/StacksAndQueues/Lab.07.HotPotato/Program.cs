using System;
using System.Collections.Generic;

namespace Lab._07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] playerNames = Console.ReadLine().Split();
            int nToss = int.Parse(Console.ReadLine());
            Queue<string> players = new Queue<string>(playerNames);

            while (players.Count > 1)
            {
                for (int i = 1; i < nToss; i++) // important algorithm 
                {
                    //players.Enqueue(players.Dequeue());
                    string playerToMoveToTheBackOfQueue = players.Dequeue();
                    players.Enqueue(playerToMoveToTheBackOfQueue);
                }

                Console.WriteLine("Removed {0}", players.Dequeue());
            }

            Console.WriteLine("Last is {0}", players.Peek());
        }
    }
}
