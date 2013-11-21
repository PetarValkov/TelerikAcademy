using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first int number: ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the second int number: ");
        int secondNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the third int number: ");
        int thirdNum = int.Parse(Console.ReadLine());

        int D = secondNum * secondNum - 4 * firstNum * thirdNum;

        if (D == 0)
        {
            Console.WriteLine("x1,x2 = {0}", -(secondNum / (2 * firstNum)));
        }
        else if (D > 0)
        {
            Console.WriteLine("x1 = {0:0.00}", (-secondNum + Math.Sqrt(D)) / 2 * firstNum);
            Console.WriteLine("x2 = {0:0.00}", (-secondNum - Math.Sqrt(D)) / 2 * firstNum);
        }
        else
        {
            Console.WriteLine("There are no real roots");
        }
    }
}

