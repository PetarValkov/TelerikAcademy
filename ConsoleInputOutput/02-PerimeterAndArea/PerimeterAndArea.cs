using System;

class PerimeterAndArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        
        double perimeter;
        double area;

        Console.WriteLine("The area of the circle is: {0,0:0.00} ", area = Math.PI*Math.Pow(radius,2));
        Console.WriteLine("The perimeter of the circle is: {0,0:0.00} ",perimeter=2*radius*Math.PI);
    }
}

