//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatОrDouble
{
    static void Main(string[] args)
    {
        double number1 = 34.567839023;
        float number2 = 12.345f;
        double number3 = 8923.123485f;
        float number4 = 3456.091f;

        Console.WriteLine("This number is double: {0}", number1);
        Console.WriteLine("This number is float: {0}", number2);
        Console.WriteLine("This number is float: {0}", number3);
        Console.WriteLine("This number is float: {0}", number4);

    }
}

