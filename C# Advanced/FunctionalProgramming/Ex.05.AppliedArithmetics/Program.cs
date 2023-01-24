int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

string commandType = Console.ReadLine();
while (commandType != "end")
{
    if (commandType == "add")
    {
        numbers = numbers.Select(x => x + 1).ToArray();
    }
    else if (commandType == "multiply")
    {
        numbers = numbers.Select(x => x * 2).ToArray();
    }
    else if (commandType == "subtract")
    {
        numbers = numbers.Select(x => x - 1).ToArray();
    }
    else if (commandType == "print")
    {
        Console.WriteLine(string.Join(" ", numbers));
    }

    commandType = Console.ReadLine();
}
