//Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:


using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Now we will calculate rectangle`s perimeter and area.");
        Console.Write("First, write the wight of the rectangle`s: ");

        double weight = double.Parse(Console.ReadLine());

        Console.Write("Second, write the height of the rectangle`s: ");

        double height = double.Parse(Console.ReadLine());

        double area = weight * height;
        double perimeter = (2 * weight) + (2 * height);
        Console.WriteLine("The Perimeter of the rectangle`s is {0} and area is {1}",perimeter, area);

    }
}
