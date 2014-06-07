//Write a program that finds the biggest of three numbers.

using System;

class TheBiggestof3Numbers
{
    static void Main()
    {
        Console.Write("Enter here first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Enter here second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        Console.Write("Enter here third number: ");
        double thirdNum = double.Parse(Console.ReadLine());

        if ( firstNum > secondNum && thirdNum < firstNum)
        {
            Console.WriteLine("The bigger number is: {0}", firstNum);
        }
        else if ( secondNum > firstNum && thirdNum < secondNum)
        {
           Console.WriteLine("The bigger number is: {0}", secondNum);
        }
        else
        {
            Console.WriteLine("The bigger number is: {0}", thirdNum);
        }
    }
}
