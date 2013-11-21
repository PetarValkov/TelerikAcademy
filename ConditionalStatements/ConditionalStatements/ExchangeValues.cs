using System;

class ExchangeValues
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The first number is {0} and second is {1}.", firstNumber, secondNumber);

        if (firstNumber > secondNumber)
        {
            int temp = secondNumber;
            secondNumber = firstNumber;
            firstNumber = temp;
        }

        Console.WriteLine("The first number is {0} and second is {1}.",firstNumber, secondNumber);
    }
}

