using System;

class MinAndMax
{
    
    static void Main(string[] args)
    {
        string firstInput;
        int N;

        do
        {
            Console.WriteLine("Please input the first int number: ");   //user input for three numbers
            firstInput = Console.ReadLine();

        } while (!int.TryParse(firstInput, out N)); //check for correct input

        int[] numbers = new int[N];
        
        for (int i = 0; i < N; i++)         //input numbers and save into an array
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int min = numbers[0];
        int max = numbers[0];

        for (int i = 0; i < N; i++)     //compare all the numbers in the array
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }

            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine("Them min is: {0}.", min);
        Console.WriteLine("Them max is: {0}.", max);
    }
}

