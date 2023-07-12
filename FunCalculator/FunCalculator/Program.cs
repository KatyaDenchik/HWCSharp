using System;
using System.Linq.Expressions;
using NCalc;

class Calculator
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введите выражение: ");
		string input = Console.ReadLine();

		NCalc.Expression expression = new NCalc.Expression(input);

		try
		{
			double result = Convert.ToDouble(expression.Evaluate());
			Console.WriteLine("Результат: " + result);
		}
		catch (EvaluationException)
		{
			Console.WriteLine("Некорректное выражение.");
		}
	}
}
