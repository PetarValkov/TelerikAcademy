using System;

class ExchangeBits
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine("Please enter an integer number: ");
            int number = Int32.Parse(Console.ReadLine());            //user input

            //we start from position number 3 and go up to 5, and from 24 up to 26
            for (int firstPos = 3, secondPos = 24; firstPos < 6; firstPos++, secondPos++)
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
            Console.WriteLine("New Binary Value: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine("New Decimal value: {0}", number);
        }
    }
}

