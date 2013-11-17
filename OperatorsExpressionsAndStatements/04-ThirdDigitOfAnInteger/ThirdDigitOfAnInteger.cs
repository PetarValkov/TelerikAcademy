using System;

class ThirdDigitOfAnInteger
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if ((number % 1000) / 100 == 7)                 //first we take only the last three numbers with module division,
                                                        //and then with the division by 100, we check the hundreds
        {
            Console.WriteLine("The third digit is 7.");
        }
        else
        {
            Console.WriteLine("The third digit is not 7.");
        }
    }
}

