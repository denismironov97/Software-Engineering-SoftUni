using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerDeck = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondPlayerDeck = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {

                if (firstPlayerDeck[0] > secondPlayerDeck[0])
                {
                    firstPlayerDeck.Add(firstPlayerDeck[0]);
                    firstPlayerDeck.Remove(firstPlayerDeck[0]);
                    firstPlayerDeck.Add(secondPlayerDeck[0]);
                    secondPlayerDeck.Remove(secondPlayerDeck[0]);
                }
                else if (firstPlayerDeck[0] < secondPlayerDeck[0])
                {
                    secondPlayerDeck.Add(secondPlayerDeck[0]);
                    secondPlayerDeck.Remove(secondPlayerDeck[0]);
                    secondPlayerDeck.Add(firstPlayerDeck[0]);
                    firstPlayerDeck.Remove(firstPlayerDeck[0]);
                }
                else
                {
                    firstPlayerDeck.Remove(firstPlayerDeck[0]);
                    secondPlayerDeck.Remove(secondPlayerDeck[0]);
                }

                if (firstPlayerDeck.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {secondPlayerDeck.Sum()}");
                    break;
                }
                else if (secondPlayerDeck.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {firstPlayerDeck.Sum()}");
                    break;
                }
            }
        }
    }
}
