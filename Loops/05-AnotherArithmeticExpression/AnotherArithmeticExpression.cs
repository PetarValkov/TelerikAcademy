using System;

class AnotherArithmeticExpression
{
    static void Main(string[] args)
    {
        string firstInput, secondNum;
        int N, K;

        do
        {
            Console.WriteLine("Please input the first int number: ");   //user input for three numbers
            firstInput = Console.ReadLine();

            Console.WriteLine("Please input the first int number: ");
            secondNum = Console.ReadLine();

        } while (!int.TryParse(firstInput, out N) || !int.TryParse(secondNum, out K) || N < 1 || N < K || K < 1); //check for correct input

        Console.WriteLine("The result is: {0}.", factorial(N) / factorial(K));
        Console.WriteLine("The result is: {0}.", (factorial(N) * factorial(K))/(K-N));
    }

    static int factorial(int N)     //same function as previous task
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

