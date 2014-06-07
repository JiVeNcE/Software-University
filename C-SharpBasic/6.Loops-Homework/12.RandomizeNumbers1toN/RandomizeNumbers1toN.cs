//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. 

using System;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] nArray = new int[n];
        Random randomNumbers = new Random();

        for (int i = 1; i <= nArray.Length; i++)
        {
            Console.Write(randomNumbers.Next(1, nArray.Length + 1) + " ");
        }

        Console.WriteLine();
    }
}
