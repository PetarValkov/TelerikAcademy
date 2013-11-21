using System;

class SignOfProduct
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int counter = 0;

        if (firstNumber < 0 )
        {
            counter++;
        }

        if (secondNumber < 0)
        {
            counter++;
        }

        if (thirdNumber < 0)
        {
            counter++;
        }

        switch (counter)
        {
            case 0:
            case 2:
                Console.WriteLine("Positive.");
                break;
            case 1:
            case 3:
                Console.WriteLine("Negative.");
                break;
            default:
                break;
        }
    }
}

