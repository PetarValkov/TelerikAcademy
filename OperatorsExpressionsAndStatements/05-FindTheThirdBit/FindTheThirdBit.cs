using System;

class FindTheThirdBit
{
    static void Main(string[] args)
    {
        int position = 3;

        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int mask = 1 << position;                     //create a mask with 1 on the third position

        int nAndMask = number & mask;                 //we check if the number has 1 on its third position

        int bit = nAndMask >> position;               //we put the bit on third position back at first

        Console.WriteLine("The third bit of the nubmer is: {0}.", bit); //we display it
    }
}

