using System;

class PointWithinCircle
{
    static void Main(string[] args)
    {
        int radius = 5;

        Console.WriteLine("Enter an x coordinate: ");
        int xCoordinate = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter an y coordinate: ");
        int yCoordinate = int.Parse(Console.ReadLine());

        //this is the formula that is used to check if a given point is within a circle taken from the Internet
        if (Math.Pow((xCoordinate - 0),2) + Math.Pow((yCoordinate - 5),2) < Math.Pow(radius,2))
        {
            Console.WriteLine("The point p({0},{1}) is withing K(0,5).",
                                              xCoordinate,yCoordinate);
        }
        else
	    {
            Console.WriteLine("The point p({0},{1}) is not in K(0,5).",
                                              xCoordinate, yCoordinate);
	    }
    }
}

