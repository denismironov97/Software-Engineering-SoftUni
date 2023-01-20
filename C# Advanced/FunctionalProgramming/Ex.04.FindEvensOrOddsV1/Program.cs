internal class Program
{
    private static void Main(string[] args)
    {
        int[] bounds = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        int lowerBound = bounds[0];
        int upperBound = bounds[1];

        string command = Console.ReadLine();

        Predicate<int> filterPredicate = n =>
        {
            if (command == "even")
            {
                return n % 2 == 0;
            }
            else
            {
                return n % 2 != 0;
            }
        };

        List<int> resultCollection = new List<int>();

        for (int i = lowerBound; i <= upperBound; i++)
        {
            if (filterPredicate(i))
            {
                resultCollection.Add(i);
            }
        }

        Console.WriteLine(string.Join(" ", resultCollection));
    }
}