using System;

class SumOfFibonacci
{
    static void Main(string[] args)
    {
        string firstInput;
        ulong N;
        ulong sum = 0;

        do
        {
            Console.WriteLine("Please input the first int number: ");   //user input for three numbers
            firstInput = Console.ReadLine();


        } while (!ulong.TryParse(firstInput, out N)); //check for correct input

        for (ulong i = 0; i < N; i++)       //sum all the numbers up to N
        {
            sum += FibSeq(i);
        }

        Console.WriteLine("The sum is {0}.",sum);
    }

    public static ulong FibSeq(ulong fib)   //this is the fibonacci method
    {
        if (fib == 0)       //if the parameter is 0, the fibonacci number is 0
        {
            return 0;
        }
        else if (fib == 1)  //if the parameter is 1, the fib number is 1
        {
            return 1;
        }
        else
        {   //else the fibonacci number is the sum of the previous two fibonacci numbers
            return FibSeq(fib - 1) + FibSeq(fib - 2);   //so i call the function recursively
        }
    }
}

