internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

        string commandType = Console.ReadLine();
        while (commandType != "end")
        {
            Action<int[]> printArray = array => Console.WriteLine(string.Join(" ", array));
            if (commandType == "print")
            {
                printArray(numbers);
            }
            else
            {
                Func<int, int> procesorOfOperationsFunc = (x) =>
                {
                    if (commandType == "add")
                    {
                        return x + 1;
                    }
                    else if (commandType == "multiply")
                    {
                        return x * 2;
                    }
                    else if (commandType == "subtract")
                    {
                        return x - 1;
                    }
                    else
                    {
                        return x;
                    }
                };

                numbers = numbers.Select(procesorOfOperationsFunc).ToArray();
            }

            commandType = Console.ReadLine();
        }
    }
}