internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        int divisor = int.Parse(Console.ReadLine());
        int[] resultColl = numbers.Where(x => x % divisor != 0).ToArray();
        resultColl = resultColl.Reverse().ToArray();
        Console.WriteLine(string.Join(' ', resultColl));
    }
}