using System;

class PrintYourName
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please write your name: ");              //promting message
        string name = Console.ReadLine();                           //assing value to a string from console input
        Console.WriteLine("Your name is: "+name);                   //displaying the message
    }
}

