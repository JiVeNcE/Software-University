//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop

using System;
using System.Collections.Generic;
using System.Linq;

class SumOfnNumbers
{
    static void Main()
    {
        Console.Write("Write your number here: ");
        double number = double.Parse(Console.ReadLine());

        int sum = 0;
        int min = 0;
        for (int i = 0; i < number; i++)
        { 
            Console.Write("Sum = ");
            sum = sum + int.Parse(Console.ReadLine());
            min = sum - i;
        }

        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine(min);
    
    }
}

