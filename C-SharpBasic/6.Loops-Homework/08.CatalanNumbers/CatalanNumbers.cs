//In combinatorics, the Catalan numbers are calculated by the following formula.
//Write a program to calculate the nth Catalan number by given n (1 < n < 100).


using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the Catalan number here: ");
        long num = long.Parse(Console.ReadLine());
        if (num > 0 && num < 31)
        {
            long numerator = 1;
            long denominator = 1;
            long result = 1;

            for (int k = 2; k <= num; k++)
            {
                numerator *= (num + k);
                if (numerator % k == 0)
                {
                    numerator /= k;
                }
                else
                {
                    denominator *= k;
                }
            }
            result = numerator / denominator;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("out of range");
        }        
    }
}
