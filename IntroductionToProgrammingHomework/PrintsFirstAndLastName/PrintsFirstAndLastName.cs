using System;

class PrintsFirstAndLastName
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please write your first name: ");
        string firstName = Console.ReadLine();                  //same as 04-PrintYour name task

        Console.WriteLine("Please write your last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Your name is: " + firstName + " " + lastName);   //display the two strings together on the console
    }
}

