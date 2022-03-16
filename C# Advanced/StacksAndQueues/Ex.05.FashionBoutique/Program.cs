using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 4 8 6 3 8 7 7 9
            //16

            int[] clothesValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();//clothes
            int capacityOfRack = int.Parse(Console.ReadLine());
            Stack<int> rack = new Stack<int>(clothesValues);
            //int rackCount = 0;V01
            int rackCount = 1;
            int rackSum = 0;

            while (rack.Any())
            {
                int currentVal = rack.Peek();

                /*
                //V01
                if (currentVal + rackSum > capacityOfRack)
                {
                    rackSum = 0;
                    rackCount++;
                }
                else if (currentVal + rackSum == capacityOfRack)
                {
                    rack.Pop();
                    rackSum = 0;
                    rackCount++;
                }
                else
                {
                    rackSum += rack.Pop();
                }
                */

                //V02
                rackSum += currentVal;

                if (rackSum <= capacityOfRack)
                {
                    rack.Pop();
                }
                else
                {
                    rackCount++;
                    rackSum = 0;
                }

            }

            /*
            //V01
            if (rackSum > 0)
            {
                rackCount++;
            }
            */

            Console.WriteLine(rackCount);
        }
    }
}
