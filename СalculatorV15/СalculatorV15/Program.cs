using System.Security.Cryptography.X509Certificates;

internal class Program
{
	private static void Main(string[] args)
	{
		string input;
		double number;

		Console.WriteLine("Введите число: ");
		input = Console.ReadLine();
		number = GetNumber(input);

		Console.WriteLine("Введите знак минуса(-), плюса(+), умножения(*) или деления(/): ");
		char sign = char.Parse(Console.ReadLine());

		Console.WriteLine("Введите число: ");
		double b = double.Parse(Console.ReadLine());

		Console.WriteLine("Для того чтобы узнать ответ нажмите Enter.");
		ConsoleKey consoleKey = Console.ReadKey().Key;

		if (sign == '+' && consoleKey == ConsoleKey.Enter)
		{
			double rezult = a + b;
			Console.WriteLine(rezult);
		}
		if (sign == '-' && consoleKey == ConsoleKey.Enter)
		{
			double rezult = a - b;
			Console.WriteLine(rezult);
		}
		if (sign == '*' && consoleKey == ConsoleKey.Enter)
		{
			double rezult = a * b;
			Console.WriteLine(rezult);
		}
		if (sign == '/' && consoleKey == ConsoleKey.Enter)
		{
			double rezult = a / b;
			Console.WriteLine(rezult);
		}
	}
	public static double GetNumber(string input)
	{
		bool isValid = double.TryParse(Console.ReadLine(), out var number);

		if (!isValid)
		{
			Console.WriteLine("Было введено не число!");
			return double.MinValue;
		}

		return number;
	}
}