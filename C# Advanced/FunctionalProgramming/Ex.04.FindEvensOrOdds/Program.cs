internal class Program
{
    private static void Main(string[] args)
    {
        //Func<string[], int[]> arrayParserFunc = strArray =>
        //{
        //    int[] numsArray = strArray.Select(x => int.Parse(x)).ToArray();
        //    return numsArray;
        //};
        //int[] nums = arrayParserFunc(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

        int[] bounds = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        int lowerBound = bounds[0];
        int upperBound = bounds[1];
        string condition = Console.ReadLine();

        Predicate<int> predicate;//filter

        switch (condition)
        {
            case "odd":
                predicate = n => n % 2 != 0;//!
                break;
            case "even":
                predicate = n => n % 2 == 0;//!
                break;
            default:
                predicate = null;
                break;
        }

        Queue<int> result = EvensOrOdds(lowerBound, upperBound, predicate);
        Console.WriteLine(string.Join(" ", result));
    }

    static Queue<int> EvensOrOdds(int lowerBound, int upperBound, Predicate<int> filter)
    {
        var numbers = new Queue<int>();

        for (int i = lowerBound; i <= upperBound; i++)
        {
            if (filter(i))
            {
                numbers.Enqueue(i);
            }
        }

        return numbers;
    }
}