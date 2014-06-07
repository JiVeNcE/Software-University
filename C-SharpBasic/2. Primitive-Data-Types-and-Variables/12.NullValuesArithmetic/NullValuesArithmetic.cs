//Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {

        int? nullValuesInt = null;
        double? nullValuesDouble = null;

        Console.WriteLine("Null values:" + nullValuesInt);
        Console.WriteLine("Null values:" + nullValuesDouble);

        nullValuesInt = nullValuesInt + 7;
        nullValuesDouble  = nullValuesInt + 9;

        Console.WriteLine("Null values:" + nullValuesInt);
        Console.WriteLine("Null values:" + nullValuesDouble);

        nullValuesInt = 7;
        nullValuesDouble = 9;

        Console.WriteLine("Null values:" + nullValuesInt);
        Console.WriteLine("Null values:" + nullValuesDouble);

    }
}
