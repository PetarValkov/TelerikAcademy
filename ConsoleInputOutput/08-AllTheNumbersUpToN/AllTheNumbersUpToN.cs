using System;

class AllTheNumbersUpToN
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Your number is: {0}.", number);

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }

    }
}

