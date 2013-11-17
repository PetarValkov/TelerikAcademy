using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int number = int.Parse(Console.ReadLine());     //user input for the number

        Console.WriteLine("Enter the position you want to check: ");
        int position = int.Parse(Console.ReadLine());   //user input for the position
                
        int mask = 1 << position;          //i create a mask with the bit on a certain position
        int result = number & mask;         //check with the number
        result = result >> position;

        if (result == 1)                    //display the result with an If statement
        {
            Console.WriteLine("True.");  
        }
        else
        {
            Console.WriteLine("False.");
        }

    }
}

