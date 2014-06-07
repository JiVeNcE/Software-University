//Write a program that reads a number n and a sequence of n integers, sorts them and prints them

using System;
using System.Collections.Generic;
using System.Linq;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("Enter your number here: ");
        int number = int.Parse(Console.ReadLine());

        int[] nums = new int[number];

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write("n= " );
            nums[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(nums);

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
}

