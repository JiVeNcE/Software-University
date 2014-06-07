//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. Examples:

using System;

class DivideBy7and5
{
    static void Main(string[] args)
    {
        Console.Write("Write the number here : ");
        int number = int.Parse(Console.ReadLine());

   
        bool isDivided = (number % 5 == 0) && (number % 7 == 0);
        
        Console.WriteLine("The number can be divided by 7 and 5 : {0}", isDivided);
    }
}

