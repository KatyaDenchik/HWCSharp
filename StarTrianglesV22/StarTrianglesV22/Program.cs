internal class Program
{
    private static void Main(string[] args)
    {
        int starFirst = 0;
        for (int i = 0; i <10 ; i++)
        {
          
            starFirst++;

            for (int j = 0; j < starFirst; j++)
            {
               
                Console.Write("*");
               
            }

            Console.WriteLine(" ");
        }

        Console.WriteLine(" ");

        int starSecond = 11;
        for (int i = 0; i <= 10; i++)
        {

            starSecond--;

            for (int j = 0; j < starSecond; j++)
            {

                Console.Write("*");

            }

            Console.WriteLine(" ");
        }

        Console.WriteLine(" ");

        int indentFirst =12;
        int starFirstOne = 0;
        for (int i = 0; i <= 10; i++)
        {
            indentFirst--;
            starFirstOne++;

            for (int j = 0; j < indentFirst; j++)
            {
                Console.Write(" ");

            }
            for (int k = 0; k < starFirstOne; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine(" ");
        }

        Console.WriteLine(" ");

        int indentSecond = 0;
        int starSecondOne = 12;
        for (int i = 0; i <= 10; i++)
        {
            indentSecond++;
            starSecondOne--;

            for (int j = 0; j < indentSecond; j++)
            {
                Console.Write(" ");

            }
            for (int k = 0; k < starSecondOne; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine(" ");
        }



    }
}