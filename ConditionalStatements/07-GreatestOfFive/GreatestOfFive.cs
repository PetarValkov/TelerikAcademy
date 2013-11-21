using System;

class BiggestOfThree
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Please input the second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Please input the third number: ");
        decimal thirdNumber = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Please input the fourth number: ");
        decimal fourthNumber = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Please input the fifth number: ");
        decimal fifthNumber = decimal.Parse(Console.ReadLine());

        decimal biggestNumber = 0;

        if (firstNumber > biggestNumber)
        {
            biggestNumber = firstNumber;
        }

        if (secondNumber > biggestNumber)
        {
            biggestNumber = secondNumber;
        }

        if (thirdNumber > biggestNumber)
        {
            biggestNumber = thirdNumber;
        }

        if (fourthNumber > biggestNumber)
        {
            biggestNumber = fourthNumber;
        }

        if (fifthNumber > biggestNumber)
        {
            biggestNumber = fifthNumber;
        }

        Console.WriteLine("The biggest number is {0}.", biggestNumber);
    }
}

