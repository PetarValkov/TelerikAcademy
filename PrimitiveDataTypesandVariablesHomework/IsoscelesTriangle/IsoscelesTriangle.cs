using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;

        char copyrightSymbol = '\u00A9';

        byte blankSpaces = 2;
        for (int i = 0; i < 3; i++)                     //the big loop is responsible for the number of rows
        {
            for (int t = 0; t < blankSpaces; t++)       //this is the loop that prints the blank spaces in each column
            {
                Console.Write(" ");
            }

            for (int j = 0; j <= i; j++)                //the loop responsible for the signs in each column
            {
                Console.Write(copyrightSymbol);
            }

            for (int j = 0; j <= i - 1; j++)        //this loop prints one more symbol each time
            {
                Console.Write(copyrightSymbol);
            }

            blankSpaces--;
            Console.WriteLine();
        }
    }
}

