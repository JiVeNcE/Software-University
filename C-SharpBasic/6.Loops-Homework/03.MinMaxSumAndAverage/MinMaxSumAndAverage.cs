//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. The output is like in the examples below.

using System;

class MinMaxSumAndAverage
{
    static void Main()
    {
        Console.Write("Enter first your number: ");
        int number = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;

        double sum = 0;
        double average = 0;

        for (int i = 0; i < number; i++)
        { 
                Console.Write("n = ");
                int allNumbers = int.Parse(Console.ReadLine());

            //min
                min = Math.Min(min, allNumbers);

            //max
                max = Math.Max(max, allNumbers);

            //sum
                sum = sum + allNumbers;

            //avetage
                average = sum / number;
        }
        Console.WriteLine("Min = {0}", min);
        Console.WriteLine("Max = {0}", max);
        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine("Average = {0:F2}", average);
    }
}
