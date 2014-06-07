//Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. 

using System;
using System.Collections.Generic;
using System.Linq;


class DifferenceBetweenDates
{
    static void Main(string[] args)
    {
        Console.Write("Enter first date in format yyyy.MM.dd : ");
        string firstDate = Console.ReadLine();
        DateTime convFirst = DateTime.Parse(firstDate);

        Console.Write("Enter second date in format yyyy.MM.dd : ");
        string secondDate = Console.ReadLine();
        DateTime convSecond = DateTime.Parse(secondDate);

        Console.WriteLine(numberOfDate(convFirst, convSecond));
    }

        static double numberOfDate( DateTime first, DateTime second)
     {
        TimeSpan t = second - first;
            double NrOfDays = t.TotalDays;

            return NrOfDays;
     }
}

