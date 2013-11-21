using System;

class UserChoiceVariable
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input something : ");
        string input = Console.ReadLine();

        double result;

        bool isNumber = double.TryParse(input,out result);

        switch (isNumber)
        {
            case true:
                Console.WriteLine("Output: {0}",result + 1);
                break;
            case false:
                Console.WriteLine("Output: {0}",input+"*");
                break;
            default:
                Console.WriteLine("Something went wrong !");
                break;
        }

    }
}

