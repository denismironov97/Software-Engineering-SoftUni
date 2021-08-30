using System;
using System.Linq;
namespace Ex._07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequenceInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            // [0] [1] [2] [3] [4] [5] [6] [7] [8] [9]
            //  2   1   1   2   3   3   2   2   2   1

            int identicalNumsLength = 1;
            int maxSequenceOfIdenticalNums = 1;
            int startIndex = 0;
            int currSequenceStartIndex = 0;

            for (int i = 1; i < sequenceInput.Length; i++)
            {
                int previusNum = sequenceInput[i - 1];
                int currNum = sequenceInput[i];
                if (previusNum == currNum)
                {
                    identicalNumsLength++;
                }
                else
                {
                    identicalNumsLength = 1;
                    currSequenceStartIndex = i;
                }

                if (identicalNumsLength > maxSequenceOfIdenticalNums)
                {
                    maxSequenceOfIdenticalNums = identicalNumsLength;
                    startIndex = currSequenceStartIndex;
                }
            }

            for (int i = startIndex; i < startIndex + maxSequenceOfIdenticalNums; i++)
            {
                Console.Write(sequenceInput[i] + " ");
            }
        }
    }
}
