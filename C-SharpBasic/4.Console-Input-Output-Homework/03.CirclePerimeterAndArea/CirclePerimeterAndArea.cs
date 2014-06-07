//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. 

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Write the radius here: ");
        double radius = double.Parse(Console.ReadLine());

         double p = 3.142;

         double perimeter = 2* (radius * p);
         double area = p * (radius * radius);

         Console.WriteLine("The perimeter of the circle is {0:F2}", perimeter);
         Console.WriteLine("The area of the circle is {0:F2}", area);




    }
}
