//Введите три числа и выведите на экран значение суммы и произведения этих чисел
using System.Security.Claims;

internal class Program
{
    private static void Main(string[] args)
    {
        double sum = 0, countNumbers = 0, product = 1;
        string input;

        while (true)
        {

            Console.WriteLine($"Если вы хотите узнать: " + "\n"
                              + "сумму чисел, напишите - сумма;" + "\n"
                              + "произведение чисел, напишите - произведение;" + "\n"
                              + "сумму и произведение чисел, напишите - сумма и произведение;" + "\n");

            Console.WriteLine("Введите число: ");
            input = Console.ReadLine();

            double number = GetNumber(input);
            if (number != double.MinValue)
            {
                sum += number;
                product *= number;
                countNumbers++;
            }

            if (input.ToLower() == "сумма" && countNumbers == 1)
            {
                Console.WriteLine($"Невозможно посчитать сумму, вы ввели одно число.");
            }
            else if (input.ToLower() == "произведение" && countNumbers == 1)
            {
                Console.WriteLine($"Невозможно посчитать произведение, вы ввели одно число.");
            }
            else if (input.ToLower() == "сумма и произведение" && countNumbers == 1)
            {
                Console.WriteLine($"Невозможно посчитать сумму и произведение, вы ввели одно число.");
            }
            else if (countNumbers == 0)
            {
                Console.WriteLine("Не было введено ни одного числа.");
            }

            else if (input.ToLower() == "сумма")
            {
                break;
            }
            else if (input.ToLower() == "произведение")
            {
                break;
            }
            else if (input.ToLower() == "сумма и произведение")
            {
                break;
            }
        }

        if (input.ToLower() == "сумма")
        {
            Console.WriteLine($"Сумма чисел = {sum}");
        }
        else if (input.ToLower() == "произведение")
        {
            Console.WriteLine($"Произведение чисел = {product}");
        }
        else if (input.ToLower() == "сумма и произведение")
        {
            Console.WriteLine($"Сумма чисел = {sum}\n Произведение чисел = {product}");
        }


    }
    public static double GetNumber(string input)
    {
        bool isValidNumber = double.TryParse(input, out var number);

        if (!isValidNumber)
        {
            Console.WriteLine("Было введено не число.");
            return double.MinValue;
        }

        return number;
    }
}