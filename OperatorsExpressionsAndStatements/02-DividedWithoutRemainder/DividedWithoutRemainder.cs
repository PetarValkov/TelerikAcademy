using System;

class DividedWithoutRemainder
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());         //user input

        if (number % 5 == 0 && number % 7 == 0)             //we check the remainder, with the logical operator AND
        {
            Console.WriteLine("The remainder is 0.");
        }
        else
        {
            Console.WriteLine("There is a remainder.");
        }
   } 
}

