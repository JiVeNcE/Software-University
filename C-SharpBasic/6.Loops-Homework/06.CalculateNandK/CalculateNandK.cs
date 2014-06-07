//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. 

using System;

class CalculateNandK
{
    static void Main()
    {
        Console.Write("Enter here the first number n: ");
        int numN = int.Parse(Console.ReadLine());
        Console.Write("Enter here the first number k: ");
        int numK = int.Parse(Console.ReadLine());

        int facturial = 1;
        for (int i = numN;  i > numK; i--)
        {
            facturial *= i;           
        }
        Console.WriteLine(facturial);
    }
}

