using System;


class GreaterNoIf
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first int number: ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the second int number: ");
        int secondNum = int.Parse(Console.ReadLine());

      // string bigger = (firstNum > secondNum) ? "The first number is bigger." : "The second number is bigger.";

       Console.WriteLine(Math.Max(firstNum,secondNum));
    }
}

