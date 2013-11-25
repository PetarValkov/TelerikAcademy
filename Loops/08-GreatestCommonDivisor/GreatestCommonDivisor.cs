using System;

class GreatestCommonDivisor
{
    static void Main(string[] args)
    {
        string firstInput, secondInput;
        int firstNum, secondNum;
        double sum = 0;

        do
        {
            Console.WriteLine("Please input the first int number: ");   //user input for three numbers
            firstInput = Console.ReadLine();

            Console.WriteLine("Please input the first int number: ");
            secondInput = Console.ReadLine();

        } while (!int.TryParse(firstInput, out firstNum) || !int.TryParse(secondInput, out secondNum)); //check for correct input

        int remainder;
        int temp;

        if (firstNum < secondNum)       //if the first number is greater, we swap the nubmers
        {
            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
        }

        do
        {
            remainder = firstNum % secondNum;       //we take the remainder
            if (remainder == 0)                 //if the remainder is 0, the algorithm stops
            {
                break;
            }
            firstNum = secondNum;           //the greater number becomes the second number
            secondNum = remainder;          //and the second number becomes the remainder

        } while (remainder != 0);

        Console.WriteLine("The GCD is {0}.",secondNum);
    }
}

