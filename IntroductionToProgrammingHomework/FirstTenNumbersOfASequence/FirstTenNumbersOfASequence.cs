using System;

class FirstTenNumbersOfASequence
{
    static void Main(string[] args)
    {
        int number;
        for (int i = 2; i < 12; i+=2)   //every iteration the loop will display two values
        {
            Console.WriteLine(i);      //all the positive even values
            number = (i * -1) - 1;      //calculating the negative value (2*-1 ) - 1 = -3, for example
            Console.WriteLine(number);//all the negative odd values
        }
    }
}

