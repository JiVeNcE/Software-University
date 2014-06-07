//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. Examples:

using System;

class BitwieExtractBits
{
    static void Main()
    {
        Console.Write("Write here the number :  ");
        int number = int.Parse(Console.ReadLine());

        int moveNumber = 3;

        int value = number >> moveNumber;

        int finaleValue = value & 1;

        Console.WriteLine("The result is : {0} ", finaleValue);


    }
}
