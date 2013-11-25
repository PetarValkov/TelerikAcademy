using System;

class AllNumbersNotDivisible
{
    static void Main(string[] args)
    {
        string firstInput;
        int N;

        do
        {
            Console.WriteLine("Please input the first int number: ");   //user input for three numbers
            firstInput = Console.ReadLine();

        } while (!int.TryParse(firstInput, out N)); //check for correct input

        for (int i = 1; i < N; i++)             //check all the numbers up to N
        {
            if (i % 3 != 0 && i % 7 != 0)       //if they are divisible without remainder they are displayed
            {
                 Console.WriteLine(i);
            }
        }
    }
}

