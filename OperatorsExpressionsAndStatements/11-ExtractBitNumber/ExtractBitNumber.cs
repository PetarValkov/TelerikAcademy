using System;

class ExtractBitNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int number = int.Parse(Console.ReadLine());     //user input for the number

        Console.WriteLine("Enter how many bits you want to extract: ");
        int bitNumber = int.Parse(Console.ReadLine());      //user input for the number of bits

        number = number >> bitNumber;                       //we take the first bits, that the user wants to extract

        Console.WriteLine("The result after the extraction is {0}.",Convert.ToString(number,2).PadLeft(32,'0'));
                                                                    //display the result in binary
    }
}

