//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. The first and the second sequence of bits may not overlap

using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("N = ");
        long numberN = long.Parse(Console.ReadLine());
        Console.Write("P = ");
        int bitP = int.Parse(Console.ReadLine());
        Console.Write("Q = ");
        int bitQ = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int lengthK = int.Parse(Console.ReadLine());
        int distance = Math.Abs(bitP - bitQ);

        if ((numberN > 4294967295) | (bitP + lengthK > 32) | (bitQ + lengthK > 32) |
                (bitP > 31 | bitQ > 31) | (bitP < 0 | bitQ < 0))
        {
            Console.WriteLine("out of range");
            Main();
        }
        uint number = (uint)numberN;
        if (distance >= lengthK)
        {
            uint unit = (1u << lengthK) - 1;  //2^k-1
            uint mask1 = ((unit << bitP) | (unit << bitQ)) & number;
            uint mask2 = (mask1 << distance) | (mask1 >> distance);
            uint result = (number & (~mask1)) | mask2;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("overlapping");
        }
    }
}
