//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0. 

using System;

class NumbersInInterval
{
    static void Main()
    {
        Console.Write("Write here the first positive integer number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Write here the second positive integer number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int p = 0;
        for (int i = firstNumber; i <= secondNumber; i++)
        {       
              if (i % 5 == 0)     
                p++;
        }
        Console.WriteLine(p);
    }
}
