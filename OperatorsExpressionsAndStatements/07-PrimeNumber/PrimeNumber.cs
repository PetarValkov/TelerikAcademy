using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter :");
        int number = int.Parse(Console.ReadLine());

        //we check if the number is 2,3,5,7
        if (number == 2 || number == 3 || number == 5 || number == 7)
        {
            Console.WriteLine("True.");
        }
            //then we check if there is a remainder when we divide by those numbers, if there is the number is not prime
        else if (number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}