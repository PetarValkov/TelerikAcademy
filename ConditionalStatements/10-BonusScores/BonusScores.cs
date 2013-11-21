using System;

class BonusScores
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the number: ");
        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("Bonus: {0}",input * 10);
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("Bonus: {0}", input * 100);
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine("Bonus: {0}", input * 1000);
                break;
            default:
                Console.WriteLine("Error!");
                break;
        }
    }
}

