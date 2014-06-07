//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). Examples:

using System;

    class PointInCircleAndOutRectangle
{
    static void Main()
    {
        Console.Write("Wite here the point x : ");
        double numberX = double.Parse(Console.ReadLine());

        Console.Write("Wite here the point y : ");
        double numberY = double.Parse(Console.ReadLine());

        double doubleXY = ((numberX -1 * numberX - 1) + (numberY - 1 * numberY - 1));

        bool isInCircle = doubleXY <= (1.5 * 1.5);
        bool isOutsideRectangle = numberX > 1 || numberX < 6 && numberY > -1 || numberY < 2;

        if (numberX == 0 || numberY == 0)
        {
            Console.WriteLine("no");
        }
        else if (isInCircle == true && isOutsideRectangle == true)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}
