using System;

namespace Average
{
    // Напишите программу, вычисляющую среднее арифметическое двух чисел


    class Program
    {

        private static void Main(string[] args)
        {
            double sum = 0, countNumbers = 0;
            while (true)
            {
                Console.Write("Введите число (для выхода введите \"ответ\"): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "ответ")
                {
                    break;
                }

                sum += GetNumber(input);
                countNumbers++;

            }
            if (countNumbers == 0)
            {
                Console.WriteLine("Не было введено ни одного числа.");
            }
            else
            {
                double average = (double)sum / countNumbers;
                Console.WriteLine("Среднее арифметическое равно " + average);
            }
        }


        public static double GetNumber(string input)
        {
            double number = 0;
            bool isValidNumber = false;
            do
            {
                bool result = double.TryParse(input, out number);

                if (result) isValidNumber = true;

                else
                {
                    Console.WriteLine("Было введено не число.");
                    Console.Write("Введите число (для выхода введите \"ответ\"): ");
                    input = Console.ReadLine();
                }
            } while (!isValidNumber);
            return number;
        }
    }
}