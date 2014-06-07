//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Write the integer number n  here : ");
        int integerNumber = int.Parse(Console.ReadLine());

        Console.Write("Write here the value of the index p : ");
        int moveNumber = int.Parse(Console.ReadLine());

        int value = integerNumber >> moveNumber;
        int finaleValue = value & 1;

        Console.WriteLine(" The finale result is : {0}", finaleValue);



    }
}
