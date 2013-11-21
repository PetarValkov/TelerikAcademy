using System;

class SumOfNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first int number: ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the second int number: ");
        int secondNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the third int number: ");
        int thirdNum = int.Parse(Console.ReadLine());

        int sum = 0;
        Console.WriteLine("The sum of {0} + {1} + {2} = {3}",firstNum,secondNum,thirdNum, 
             sum = firstNum + secondNum + thirdNum);

        
    }
}

