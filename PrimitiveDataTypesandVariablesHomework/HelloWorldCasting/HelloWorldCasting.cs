using System;

class HelloWorldCasting
{
    static void Main(string[] args)
    {
        string hello = "Hello";                     //declaring two string
        string world = "World";

        object concatenation = hello + world;       //concatenating them
        Console.WriteLine(concatenation);

        string newValue = (string)concatenation;    //displaying the concatenated string using type casting
        Console.WriteLine(newValue);
    }
}   

