using System;

class ExchangeTwoValues
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a number: ");           //promting the user to input 2 numbers
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input a second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The first number is {0} and the second is {1}.",     //displaying them before the exchange
                                                    firstNumber, secondNumber);

        int tempValue = firstNumber;                //assigning the first number to a temporary variable
        firstNumber = secondNumber;                 //assigning the second number to the first number
        secondNumber = tempValue;                   //assigning the temporary variable to the secondNumber variable

        Console.WriteLine("After the exchange the first number is {0} and the second is {1}.",
                                                firstNumber, secondNumber);         //displaying the new values
    }
}

