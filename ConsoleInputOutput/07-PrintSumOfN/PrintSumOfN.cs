using System;

class PrintSumOfN
{
    static void Main(string[] args)
    {
        int number;
        int sum = 0;
        ConsoleKeyInfo key;

        do
        {
            Console.WriteLine("Please enter a number: ");
            number = int.Parse(Console.ReadLine());
            sum += number;
            Console.WriteLine("The sum is: {0}", sum);
            Console.WriteLine("Press Enter to continue or ESC to quit.");
            key = Console.ReadKey();
        } while (key.Key != ConsoleKey.Escape);
    }
}

