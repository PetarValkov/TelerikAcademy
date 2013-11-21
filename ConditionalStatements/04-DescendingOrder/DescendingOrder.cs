using System;

class DescendingOrder
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Please input the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Please input the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine("The numbers are {0}, {1}, {2}.", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("The numbers are {0}, {1}, {2}.", firstNumber, thirdNumber, secondNumber);
                }
            }
            else
            {
                Console.WriteLine("The numbers are {0}, {1}, {2}.", thirdNumber, firstNumber, secondNumber);
            }
            
        }
        else if (secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("The numbers are {0}, {1}, {2}.", secondNumber, firstNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("The numbers are {0}, {1}, {2}.", secondNumber, thirdNumber, firstNumber);
            }
        }
        else
        {
            Console.WriteLine("The numbers are {0}, {1}, {2}.", thirdNumber, secondNumber, firstNumber);
        }
    }
}

