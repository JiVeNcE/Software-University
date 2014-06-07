//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Write here the coefficient a: ");
        double coefA = double.Parse(Console.ReadLine());
        Console.Write("Write here the coefficient b: ");
        double coefB = double.Parse(Console.ReadLine());
        Console.Write("Write here the coefficient c: ");
        double coefC = double.Parse(Console.ReadLine());

        double x1, x2;

        x1 = (-coefB - Math.Sqrt(coefB * coefB - 4 * coefA * coefC)) / (2 * coefA);
        x2 = (-coefB + Math.Sqrt(coefB * coefB - 4 * coefA * coefC)) / (2 * coefA);

        Console.WriteLine("the result of x1={0} x2={1}",x1, x2);
    }
}
