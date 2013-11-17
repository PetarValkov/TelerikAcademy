using System;

class TrapezoidArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a value for a :");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a value for b :");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a number for h :");
        int h = int.Parse(Console.ReadLine());

        Console.WriteLine("The trapezoid's area is: {0}.", (double)((a+b)*h)/2); //multiplication and divison

    }
}

