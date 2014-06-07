//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned

using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Write here the integer number a : ");
        int numberA = int.Parse(Console.ReadLine());
        Console.Write("Write here the floating-poing b : ");
        float numberB = float.Parse(Console.ReadLine());
        Console.Write("Write here the floating-point c : ");
        float numberC = float.Parse(Console.ReadLine());

        string binaryResult = Convert.ToInt32(Convert.ToString(numberA, 2)).ToString("0000000000");

        Console.WriteLine("|{0,-10:X}|{1,-10}|{2,10:F2}|{3,-10:F3}|", numberA, binaryResult, numberB, numberC);
    }
}
