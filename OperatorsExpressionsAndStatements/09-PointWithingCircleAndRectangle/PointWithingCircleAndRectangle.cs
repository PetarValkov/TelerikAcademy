using System;

class PointWithingCircleAndRectangle
{
    static void Main(string[] args)
    {
        int radius = 3;

        Console.WriteLine("Enter an x coordinate: ");
        int xCoordinate = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter an y coordinate: ");
        int yCoordinate = int.Parse(Console.ReadLine());

        //i use the same formula from the previous task
        if (Math.Pow((xCoordinate - 1), 2) + Math.Pow((yCoordinate - 1), 2) < Math.Pow(radius, 2))
        {
            Console.WriteLine("The point p({0},{1}) is withing K((1,1),3).",
                                              xCoordinate, yCoordinate);
            //then i check if it is somewhere in the rectangle
            if ((xCoordinate < - 1 || xCoordinate > 5) || ( yCoordinate > 1 || yCoordinate < - 1))
            {
                Console.WriteLine("The point is outside the rectangle.");
            }
            else
            {
                Console.WriteLine("The point is inside the rectangle.");
            }
        }
        else
        {
            //the else statement is the same, just with different display output
            Console.WriteLine("The point p({0},{1}) is not in K((1,1),3).",
                                              xCoordinate, yCoordinate);
            if ((xCoordinate < -1 || xCoordinate > 5) || (yCoordinate > 1 || yCoordinate < -1))
            {
                Console.WriteLine("The point is outside the rectangle.");
            }
            else
            {
                Console.WriteLine("The point is inside the rectangle.");
            }
        }
    }
}

