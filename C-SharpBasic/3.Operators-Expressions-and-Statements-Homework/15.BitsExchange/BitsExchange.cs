//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer

using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter the number:");
        int n = int.Parse(Console.ReadLine());

        int mask = 7;

        int mask1 = mask << 3;
        int mask2 = mask << 24;
        int gettingFirstBits = (mask1 & n) << 21;
        int gettingSecondBits = (mask2 & n) >> 21;
        int mask3 = ~mask1 & n;
        int mask4 = ~mask2 & n;
        n = (gettingFirstBits | gettingSecondBits) | (mask3 & mask4);
        Console.WriteLine(n);

    }
}
