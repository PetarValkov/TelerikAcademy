using System;

class DivisibleByFive
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first int number: ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the second int number: ");
        int secondNum = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = firstNum; i <= secondNum; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("The numbers between {0} and {1} that are divisible by 5 are {2}."
                                                 ,firstNum,secondNum,counter);
    }
}

