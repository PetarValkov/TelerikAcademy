using System;

class ExchangeBitsFormula
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number: ");       //user input for all the variables
        int number = int.Parse(Console.ReadLine());


        Console.WriteLine("How much bits do you want to change: ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the position you want to start from : ");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the second position : ");
        int q = int.Parse(Console.ReadLine());

        while (p + k > 32 || q + k > 32 || p > q)           //check the user input
        {
            Console.WriteLine("Please enter a correct input!");
            Console.WriteLine("How much bits do you want to change: ");
            k = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the position you want to start from : ");
            p = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the second position : ");
            q = int.Parse(Console.ReadLine());
        }

        //we start from position number p and go up to p + k -1, and from q up to q+k - 1
        for (int firstPos = p, secondPos = q; firstPos < p + k; firstPos++, secondPos++)
        {

            int mask1 = 1 << firstPos;      //create two masks with the two positions
            int mask2 = 1 << secondPos;

            int nAndMask1 = number & mask1;          //find out whether the bits on the positions are 1 or 0
            int bit1 = nAndMask1 >> firstPos;
            int nAndMask2 = number & mask2;
            int bit2 = nAndMask2 >> secondPos;

            int temp = bit1;                    //exchange the bits
            bit1 = bit2;
            bit2 = temp;

            if (bit1 == 0 && bit2 == 1)         //put the new bits into the number
            {
                number = (number & ~mask1) | mask2;

            }
            else if (bit1 == 1 && bit2 == 0)
            {
                number = (number | mask1) & ~mask2;

            }

           
        }
        Console.WriteLine("The new number is: {0}.", Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}

