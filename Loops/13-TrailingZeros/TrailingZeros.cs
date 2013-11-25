using System;
using System.Numerics;

class TrailingZeros
{
    static void Main(string[] args)
    {
        string firstInput;
        BigInteger N;

        do
        {
            Console.WriteLine("Please input the first int number: ");   //user input for three numbers
            firstInput = Console.ReadLine();

        } while (!BigInteger.TryParse(firstInput, out N)); //check for correct input

        BigInteger fact;
        int counter = 0;

        fact = factorial(N);                //we calculate the factorial of the number

        string number = fact.ToString();        //we make the factorial a string

        int len = number.Length;            //take the length of the string

        while (number[len-1] == '0')        //we start from the end, and count how much zeros are there
        {
            counter++;
            len--; 
        }
        Console.WriteLine("The factorial of N is : {0}",fact);
        Console.WriteLine("The ending zeros are: {0}",counter);
        
    }

    static BigInteger factorial(BigInteger N)
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

