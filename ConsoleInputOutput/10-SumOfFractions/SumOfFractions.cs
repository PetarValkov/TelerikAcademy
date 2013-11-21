using System;

class SumOfFractions
{
    static void Main(string[] args)
    {
        decimal counter = 2;
        decimal sum = 1;

        do
        {
            if (counter % 2 == 0)
            {
                sum += 1 / counter;
                counter++;
            }
            else
            {
                sum += -1 / counter;
                counter++;
            }
        } while (1m / counter > 0.001m);

        Console.WriteLine("The sum is {0,0:0.000}", sum);
    }
}

