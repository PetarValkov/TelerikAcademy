using System;

class FibonacciSeq
{
    static void Main(string[] args)
    {
        for (ulong i = 0; i <= 100; i++)
        {
            Console.WriteLine("The {0} number is : {1}.",i,FibSeq(i));
        }
        
    }

    public static ulong FibSeq(ulong fib)
    {
        if (fib == 0)
        {
            return 0;
        }
        else if (fib == 1)
        {
            return 1;
        }
        else
        {
            return FibSeq(fib - 1) + FibSeq(fib - 2);
        }
    }
}

