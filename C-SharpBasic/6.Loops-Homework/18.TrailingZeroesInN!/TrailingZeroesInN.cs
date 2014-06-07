//Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should work well for very big numbers, e.g. n=100000.

using System;
using System.Numerics; 

    class Program
    {
        static void Main()
        {
            Console.Write("Enter here the first number n: ");
            int numN = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 1; i <= numN ; i++)
            {
                factorial *= i;
            }
           
            //check for number of trailing zeros 
            int zeros = 0;
            
            while (factorial % 10 == 0)
            {
                zeros++;
                factorial /= 10;              
            }
            Console.WriteLine(zeros);
        }
    }
