using System;

class QuotedStrings
{
    static void Main(string[] args)
    {
        string firstWay = "The \"use\" of quotations causes difficulties."; //using the escape symbol
        Console.WriteLine(firstWay);

        string quotation = @"The ""use"" of quatations causes difficulties."; //using @ symbol
        Console.WriteLine(quotation);
    }
}

