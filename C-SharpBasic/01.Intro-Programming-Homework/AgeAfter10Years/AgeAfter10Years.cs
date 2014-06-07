using System;


class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter date of birth mm/dd/yyyy:");
        DateTime birthDay = DateTime.Parse(Console.ReadLine());
        TimeSpan difference = DateTime.Now.Subtract(birthDay);
        Console.WriteLine("Now you are {0} years old.", difference.Days / 365);
        Console.WriteLine("In 10 years you will be {0}!", (difference.Days / 365) + 10);
    }
}
