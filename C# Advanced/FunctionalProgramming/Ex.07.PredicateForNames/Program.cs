internal class Program
{
    private static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

        Predicate<string> filterLengthPredicate = text => text.Length > length;
        names.RemoveAll(filterLengthPredicate);

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}