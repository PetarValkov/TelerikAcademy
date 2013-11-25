using System;

class DeckOfCards
{
    static void Main(string[] args)
    {
        string[] colors = { "Clubs", "Diamonds", "Hearts", "Spades" };  //an array for the colors of the cards

        foreach (var color in colors)                           //takes an element from the array with the colors
        {
            for (int i = 2; i <= 14; i++)                       //switch statement for all the cards
            {
                switch (i)
                {
                    case 2:
                        Console.WriteLine("Two of " + color);
                        break;       
                    case 3:
                        Console.WriteLine("Three of " + color);
                        break;       
                    case 4:
                        Console.WriteLine("Four of " + color);
                        break;       
                    case 5:
                        Console.WriteLine("Five of " + color);
                        break;      
                    case 6:         
                        Console.WriteLine("Six of " + color);
                        break;      
                    case 7:
                        Console.WriteLine("Seven of " + color);
                        break;     
                    case 8:
                        Console.WriteLine("Eight of " + color);
                        break;      
                    case 9:
                        Console.WriteLine("Nine of " + color);
                        break;      
                    case 10:
                        Console.WriteLine("Ten of " + color);
                        break;      
                    case 11:
                        Console.WriteLine("Jack of " + color);
                        break;      
                    case 12:
                        Console.WriteLine("Qeen of " + color);
                        break;      
                    case 13:
                        Console.WriteLine("King of " + color);
                        break;
                    case 14:
                        Console.WriteLine("Ace of " + color);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

