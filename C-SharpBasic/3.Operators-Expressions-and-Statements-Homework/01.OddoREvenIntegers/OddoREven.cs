//Write an expression that checks if given integer is odd or even. Examples:

using System;
class OddEven
{
    static void Main()
    {
        Console.Write("Write the number here: ");
        int number = int.Parse(Console.ReadLine());
        bool isEven = number % 2 == 0;

        Console.WriteLine("The number is Even: {0}", isEven);

    }
}
