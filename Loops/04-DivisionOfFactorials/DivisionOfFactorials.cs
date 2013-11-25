using System;

class DivisionOfFactorials
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

        } while (!int.TryParse(firstInput, out N) || !int.TryParse(secondNum, out K)
            || N < 1 || N < K || K < 1); //check for correct input
        Console.WriteLine("The result is: {0}.",factorial(N)/factorial(K));
    }

    static int factorial(int N) //this is the method for the factorial
    {
        if (N == 0)             //if the number is 0, the factorial is 1
        {
            return 1;
        }
        else if (N == 1)        //if it is 1, the factorial is 1
        {
            return 1;
        }
        else
        {
            return N*factorial(N-1);        //else we return N multiplied by the factorial of the previous number
        }
    }
}

