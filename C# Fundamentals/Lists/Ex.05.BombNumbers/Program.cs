using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombData = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int specialBombNum = bombData[0];
            int bombPower = bombData[1];
            int bombIndexInList = numbersList.IndexOf(specialBombNum);

            while (bombIndexInList != -1)
            {
                int leftNumbers = bombIndexInList - bombPower;
                int rightNumbers = bombIndexInList + bombPower;
                if (leftNumbers < 0)
                {
                    leftNumbers = 0;
                }
                if (rightNumbers > numbersList.Count - 1)
                {
                    rightNumbers = numbersList.Count - 1;
                }
                numbersList.RemoveRange(leftNumbers, rightNumbers - leftNumbers + 1); // important method for list 
                bombIndexInList = numbersList.IndexOf(specialBombNum);
            }
            int sumOfListAfterDetonation = default;
            foreach (int number in numbersList)
            {
                sumOfListAfterDetonation += number;
            }
            Console.WriteLine(sumOfListAfterDetonation);
        }
    }
}
