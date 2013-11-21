using System;

class BiggestOfThree
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int biggestNumber = 0;

        if (firstNumber > biggestNumber)
        {
            biggestNumber = firstNumber;

            if (secondNumber > biggestNumber)
            {
                biggestNumber = secondNumber;

                if (thirdNumber > biggestNumber)
                {
                    biggestNumber = thirdNumber;
                }
            }
        }

        Console.WriteLine("The biggest number is {0}.",biggestNumber);
    }
}

