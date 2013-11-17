using System;

class OddorEven
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer: ");
        int newInt = int.Parse(Console.ReadLine());         //user input

        if (newInt % 2 == 0)                                //module division, if the remainder is 0, the number is even
        {
            Console.WriteLine("The integer is even");
        }
        else
        {
            Console.WriteLine("The integer is odd.");
        }
    }
}

