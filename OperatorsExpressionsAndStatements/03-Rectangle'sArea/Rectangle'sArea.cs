using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a width: ");
        int width = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter a height: ");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine("The area of the rectange is {0}.", width*height);        //multiplication between the two numbers
    }
}

