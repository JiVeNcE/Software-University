//Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements). If multiple sequences have the same maximal length, print the leftmost of them. 

using System;
using System.Collections.Generic;
using System.Linq;

class LongestAreaInArray
{
    static void Main()
    {
        Console.Write("Enter integer number n: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter some strings here: ");    
        string[] array = new string[number];
        
        for (int i = 0; i < array.Length; i++)
        {        
            array[i] = Console.ReadLine();
        }


        string currString = array[0];
        Array.Sort(array);
        int currLength = 1;
        int bestLength = currLength;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                currLength++;
            }

            else
            {
                currLength = 1;
            }

            if (bestLength < currLength)
            {
                bestLength = currLength;
                currString = array[i];
            }
        }
        Console.WriteLine(bestLength);
        for (int i = 0; i < bestLength; i++)
        {
            Console.WriteLine(currString);
        }
      
    }
}

