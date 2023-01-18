using System;
using System.Linq;

namespace Ex._03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            Func<int[], int> getMinValFunc = arrayNums =>
            {
                int minVal = int.MaxValue;
                foreach (int number in arrayNums)
                {
                    if (number < minVal)
                    {
                        minVal = number;
                    }
                }

                return minVal;
            };

            Console.WriteLine(getMinValFunc(numbers));
        }
    }
}
