using System;
using System.Linq;

namespace Lab._02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            Func<int[], int> lengthOfArrayFunc = x => x.Length;
            int resultLength = lengthOfArrayFunc(numbers);

            Func<int[], int> sumElementsArrayFunc = GetSumOfElementsArray;
            //var sumOfElemtsInArray = GetSumOfElementsArray(numbers);
            var sumOfElemtsInArray = sumElementsArrayFunc(numbers);

            Console.WriteLine(resultLength);
            Console.WriteLine(sumOfElemtsInArray);
        }

        private static int GetSumOfElementsArray(int[] nums)
        {
            int sum = 0;

            foreach (int num in nums)
            {
                sum += num;
            }

            return sum;
        }
    }
}
