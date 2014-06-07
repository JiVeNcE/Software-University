//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        bool inRange = n >= 1 && n <= 20;
        if (inRange)
        {
            PrintArray(Spiral(n));
        }
        else
        {
            Console.WriteLine("Invalid input. Correct input --> 1 <= n <= 20");
        }

    }

    public static int[,] Spiral(int n)
    {
        int[,] result = new int[n, n];

        int pos = 1;
        int count = n;
        int value = -n;
        int sum = -1;

        do
        {
            value = -1 * value / n;
            for (int i = 0; i < count; i++)
            {
                sum += value;
                result[sum / n, sum % n] = pos++;
            }
            value *= n;
            count--;

            for (int i = 0; i < count; i++)
            {
                sum += value;
                result[sum / n, sum % n] = pos++;
            }

        } while (count > 0);

        return result;
    }


    // Method to print arrays, pads numbers so they line up in columns
    public static void PrintArray(int[,] array)
    {
        int n = (array.GetLength(0) * array.GetLength(1) - 1).ToString().Length + 1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j].ToString().PadLeft(n, ' '));
            }
            Console.WriteLine();
        }
    }
}