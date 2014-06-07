//Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Write first number here: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Write second number here: ");
        double secondNumber = double.Parse(Console.ReadLine());

        double ifGreeter ;

        if (firstNumber > secondNumber)
        {
            ifGreeter = firstNumber;
            firstNumber = secondNumber;
            secondNumber = ifGreeter;

            Console.WriteLine(firstNumber + " " + secondNumber);
        }

        else 
        {
            Console.WriteLine(firstNumber + " " + secondNumber);
        }
    }
}
