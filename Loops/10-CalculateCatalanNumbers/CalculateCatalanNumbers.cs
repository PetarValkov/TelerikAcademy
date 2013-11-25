using System;

class CalculateCatalanNumbers
{
    static void Main(string[] args)
    {
        string firstInput;
        double N;

        do
        {
            Console.WriteLine("Please input the first int number: ");   //user input for three numbers
            firstInput = Console.ReadLine();

        } while (!double.TryParse(firstInput, out N)); //check for correct input

        Console.WriteLine("The catalan sum is {0}.",catalan(N));
    }

    static double catalan(double N) //the method for the catalan numbers
    {
        double catalanNum;

        catalanNum = factorial(2 * N) / (factorial(N + 1) * factorial(N));

        return catalanNum;

    }

    static double factorial(double N)       //the method for the factorial
    {
        if (N == 0)
        {
            return 1;
        }
        else if (N == 1)
        {
            return 1;
        }
        else
        {
            return N * factorial(N - 1);
        }
    }
}

