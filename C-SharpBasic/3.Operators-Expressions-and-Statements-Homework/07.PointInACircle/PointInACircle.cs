//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). Examples:

using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Wite here the x point to check if is inside in a circle: ");
        double numberX = double.Parse(Console.ReadLine());

        Console.Write("Wite here the y point to check if is inside in a circle: ");
        double numberY = double.Parse(Console.ReadLine());

        double doubleXY = ((numberX * numberX) + (numberY * numberY));

        bool finaleR = doubleXY <= (2*2);

        Console.WriteLine("The {0} and {1} are inside in the Circle : {2}", numberX, numberY, finaleR);







    }
}

