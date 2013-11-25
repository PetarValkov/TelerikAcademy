using System;

class CalculateTheSum
{
    static void Main(string[] args)
    {
        string firstInput, secondNum;
        int N, X;
        double sum = 0;

        do
        {
            Console.WriteLine("Please input the first int number: ");   //user input for three numbers
            firstInput = Console.ReadLine();

            Console.WriteLine("Please input the first int number: ");
            secondNum = Console.ReadLine();

        } while (!int.TryParse(firstInput, out N) || !int.TryParse(secondNum, out X)); //check for correct input
        
        for (int i = 1; i <= N; i++)        //sum all the numbers
        {
            sum += factorial(i) / Math.Pow(X, i);
        }

        Console.WriteLine("The sum is : {0}.", sum);   //display the sum
    }

    static double factorial(double N)
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

