using System;

class CompareFloatingPointNumbers
{
    static void Main(string[] args)
    {
        double precision = 0.000001;                                //the precision used in the comparison
        Console.WriteLine("Please input a floating point number :");  //promting the user for input
        double firstNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Please input a second floating point number :");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Clear();

        if (Math.Abs(firstNumber - secondNumber) <= precision)      //comparing the numbers using the given precision
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

