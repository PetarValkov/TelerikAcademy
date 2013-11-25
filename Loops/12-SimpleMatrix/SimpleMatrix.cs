using System;

class SimpleMatrix
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

        for (int i = 1; i <= N; i++)            //the big loop is for the rows
        {
            for (int j = i; j < N+i; j++)       //the small loop is for the columns
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}

