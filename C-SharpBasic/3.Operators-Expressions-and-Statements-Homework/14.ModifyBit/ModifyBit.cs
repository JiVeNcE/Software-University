//We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. 

using System;

class ModifyBit
{
    static void Main()
    {

        Console.Write("Write the integer number n here : ");
        int numberN = int.Parse(Console.ReadLine());

        Console.Write("Write the position p here : ");
        int positionP = int.Parse(Console.ReadLine());

        Console.Write("Write the value v here : ");
        int valueV = int.Parse(Console.ReadLine());

        int mask = valueV << positionP;
        int finaleValue = numberN | mask;

        if (valueV == 0)
        {
            mask = ~(1 << positionP);
            finaleValue = numberN & mask;
        }
        Console.WriteLine("The result is : {0}", finaleValue);
    }
}

