using System;

class NumbersFromOneToN
{
    static void Main()
    {
        string firstInput;
        int N;

        do
        {
            Console.WriteLine("Please input the first int number: ");   //user input for three numbers
            firstInput = Console.ReadLine();

        } while ( !int.TryParse(firstInput, out N)); //check for correct input
            

        for (int i = 1; i < N; i++)     //display all the numbers up to N
        {
            Console.WriteLine(i);
        }
    }

}

