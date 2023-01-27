internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        int divisor = int.Parse(Console.ReadLine());

        Func<int[], int[]> reverseArrayFunc = array =>
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tempVal = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = tempVal;
            }

            return array;
        };

        numbers = reverseArrayFunc(numbers);
        Predicate<int> predicate = n => n % divisor != 0;
        Queue<int> filteredCollection = new Queue<int>();

        foreach (int num in numbers)
        {
            if (predicate(num))
            {
                filteredCollection.Enqueue(num);
            }
        }

        Console.WriteLine(string.Join(" ", filteredCollection));
    }
}