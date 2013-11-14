using System;

class NullValues
{
    static void Main(string[] args)
    {
        int? number = null;                     //assigning the null values
        double? secondNumber = null;
            
        Console.WriteLine(number);              //trying to display them
        Console.WriteLine(secondNumber);

        number += 5;                            //adding five to the number variable

        Console.WriteLine(number + 5);              //displaying both variables with an arithmetic operation
        Console.WriteLine(secondNumber + 3.5);
    
    }
}

