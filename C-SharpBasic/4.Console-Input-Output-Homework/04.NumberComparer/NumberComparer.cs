﻿//Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements. 

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Write here the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Write here the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        double result = Math.Max(firstNumber, secondNumber);

        Console.WriteLine("The bigger number is : {0}", result);


    }
}

