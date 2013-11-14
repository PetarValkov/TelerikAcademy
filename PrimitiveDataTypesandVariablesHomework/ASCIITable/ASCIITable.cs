using System;
using System.Text;

class ASCIITable
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;

        for (int i = 0; i < 127; i++)       //the standart ASCII is 127 symbols, so this is the limit of the loop
        {
            Console.WriteLine((char)i);     //displaying each symbol using type casting
        }
    }
}

