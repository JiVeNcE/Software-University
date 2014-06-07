//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops.

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Write your number  here: ");
        int number = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        for (int i = 0; i < number; i++)
        {      
            int temp = a;
            a = b;
            b = temp + b;
            Console.Write(temp + " ");
        }
        Console.WriteLine();
    }
}
