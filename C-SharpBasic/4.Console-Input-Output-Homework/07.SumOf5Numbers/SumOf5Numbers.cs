//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 

using System;
using System.Collections.Generic;
using System.Linq;
class SumOf5Numbers
{  
    static void Main(string[] args)
    {
        Console.Write("Write 5 numbers separated be a space: ");
        string input = Console.ReadLine();
        int numbers = input.Split(' ').Sum(x => int.Parse(x));
        Console.WriteLine(numbers);
    }
}
