//A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. Note that you may need to learn how to parse dates and times.

using System;
using System.Globalization;

class Program
{
    static void Main()
    {

        Console.Write("Please enter a time in format “hh:mm tt” : ");
        string systemDate = Console.ReadLine();


        DateTime convertTime = DateTime.Parse(systemDate);




        string after = "1:00 PM";
        DateTime compareDate = DateTime.Parse(after);
        string before = "3:00 AM";
        DateTime beforeThree = DateTime.Parse(after);

        if (compareDate <= convertTime)
        {
            Console.WriteLine("beer time");
        }
        else if (beforeThree > convertTime)
        {
            Console.WriteLine("non beer time ");
        }
        else
        {
            Console.WriteLine("invalid time");
        }

    }
}