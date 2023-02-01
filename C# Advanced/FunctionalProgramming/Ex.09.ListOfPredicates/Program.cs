internal class Program
{
    private static void Main(string[] args)
    {
        int numN = int.Parse(Console.ReadLine());
        int[] divisors = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<int> allNumbers = new List<int>();

        for (int i = 1; i <= numN; i++)
        {
            allNumbers.Add(i);
        }

        Func<int, int[], bool> checkDivisorsFunc = (number, divisorsArr) =>
        {
            bool devided = true;
            for (int i = 0; i < divisorsArr.Length; i++)
            {
                if (number % divisorsArr[i] != 0)
                {
                    devided = false;
                }
            }
            return devided;
        };

        int[] resultColl = allNumbers.Where(x => checkDivisorsFunc(x, divisors)).ToArray();
        Console.WriteLine(string.Join(' ', resultColl));
    }
}