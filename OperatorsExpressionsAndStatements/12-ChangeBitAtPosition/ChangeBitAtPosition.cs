using System;

class ChangeBitAtPosition
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int number = int.Parse(Console.ReadLine()); //user input for the number

        Console.WriteLine("Enter the position you want to change: ");
        int position = int.Parse(Console.ReadLine());       //user input for the position

        Console.WriteLine("Enter the value you want to input (0/1): ");
        int value = int.Parse(Console.ReadLine());      //user input for the bit value

        while (value != 1 && value != 0)            //a check for correct user input
        {
             Console.WriteLine("Enter the value you want to input (0/1): ");
             value = int.Parse(Console.ReadLine());      //user input for the bit value
        }

        int mask = 1 << position;                       //create a mask with the value

        if (value == 1)
        {
            number |= mask;                             //if the bit you want to input is 1, we use bit OR
            Console.WriteLine("The new number is : {0}.",number);
        }
        else
        {
            number &= ~mask;                //if it is 0, we use bit AND, and we reverse all the bits of the mask

            Console.WriteLine("The new number is : {0}.", Convert.ToString(number, 2).PadLeft(32, '0'));
        }
   
    }
}

