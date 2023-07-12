internal class Program
{
    private static void Main(string[] args)
    {
        int count = 0;
        int even = 0;
        int odd = 0;

        int limit = int.Parse(Console.ReadLine());

        while (count < limit)
        {
            count++;
            Console.WriteLine($"{count}");
            if (count % 2 == 0) even++;
            else odd++;
        }
        Console.WriteLine($"Чётных чисел: {even}\n" +
                          $"Нечётных чисел: {odd}");
    }
}