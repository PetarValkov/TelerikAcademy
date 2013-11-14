using System;

class BooleanVariable
{
    static void Main(string[] args)
    {
        bool isFemale = false;                              //declaring of the value

        if (isFemale)                                       //checking if it is true or false
        { 
            Console.WriteLine("The person who wrote the program is a female");  //displaying a message on the console
        }
        else
        {
            Console.WriteLine("The person who wrote the program is a male");
        }
    }
}
