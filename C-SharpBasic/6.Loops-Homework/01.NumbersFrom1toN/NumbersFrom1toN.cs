//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space

using System;

class NumbersFrom1toN
{
    static void Main()
    {
        Console.Write("Enter your number here: ");
        int number = int.Parse(Console.ReadLine());

      int counter = 1;
      while (counter <= number)
      {
          Console.Write("{0}", counter + " ");
          counter++;
      }
      Console.WriteLine();
    }
}
