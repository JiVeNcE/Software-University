//Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class SumOf3Integers
{
    static void Main()
    {

        Console.Write("Write here the first integer numbers : ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Write here the second integer numbers : ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Write here the third integer numbers : ");
        double numberC = double.Parse(Console.ReadLine());

        double sum = numberA + numberB + numberC;

        Console.WriteLine("The sum of your numbers is : {0}", sum);
    }
}
