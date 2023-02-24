using System;

namespace Average
{
    // Напишите программу, вычисляющую среднее арифметическое двух чисел


    class Program
    {

        private static void Main(string[] args)
        {
            //double firstnumber, secondnumber, average;

            //Console.WriteLine("Введите первое число: ");
            //firstnumber = GetNumber();

            //Console.WriteLine("Введите второе число: ");
            //secondnumber = GetNumber();

            //average = (firstnumber + secondnumber) / 2;
            //Console.WriteLine($"Среднее арифметическое числа {firstnumber} и числа {secondnumber} будет равняться: {average}");

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
            //var answer = Console.ReadLine();
            bool result = double.TryParse(input, out var number);

            if (result) return number;

            else
            {
                //if (answer == "ответ")
                //{
                //    Console.WriteLine("ураааа");
                //}
                Console.WriteLine("Было введено не число. Введите число");
                return GetNumber(input);
            }
        }
    }
}