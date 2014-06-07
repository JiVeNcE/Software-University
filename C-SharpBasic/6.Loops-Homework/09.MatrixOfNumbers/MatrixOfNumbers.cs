//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. 

using System;

class MatrixOfNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter your number here: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {                           
                for (int k = i; k < num + i ; k++)
                {                   
                   Console.Write("{0,2} ", k);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

