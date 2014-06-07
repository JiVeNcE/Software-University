//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Now we will calculates trapezoid's area by given sedes a and b and height h");
        Console.Write("Write here the sides a :");
        double sideA = double.Parse(Console.ReadLine());

        Console.Write("Write here the sedes b : ");
        double sideB = double.Parse(Console.ReadLine());

        Console.Write("Write here the height h: ");
        double height = double.Parse(Console.ReadLine());

        double area = ((sideA + sideB) / 2) * height;

        Console.WriteLine("The are of the trapezoid is : {0}", area);
    }

    
}
