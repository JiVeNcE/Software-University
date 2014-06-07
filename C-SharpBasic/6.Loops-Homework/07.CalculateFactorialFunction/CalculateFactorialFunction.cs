//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula:
//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.


using System;
using System.Numerics;

class CalculateFactorialFunction
{
    static void Main()
    {
        Console.Write("Enter here the first number n: ");
        int numN = int.Parse(Console.ReadLine());
        Console.Write("Enter here the first number k: ");
        int numK = int.Parse(Console.ReadLine());


        BigInteger factorial = 1;
         for (int i = numN; i > numK; i--)
         {
             factorial *= i;
         }

         BigInteger dividerFactorial = 1;
         for (int j = 2; j <= (numN - numK); j++)
         {
             dividerFactorial *= j;
         }

         BigInteger result = factorial / dividerFactorial;
         Console.WriteLine(result);
    }
}
