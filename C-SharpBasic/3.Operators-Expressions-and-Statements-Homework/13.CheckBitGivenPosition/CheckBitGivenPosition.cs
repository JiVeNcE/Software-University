//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. Examples:

using System; 

class CheckBitGivenPosition
{
    static void Main()
    {
        Console.Write("Write here the number n : ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Write here the number of  position p : ");
        int positionNumber = int.Parse(Console.ReadLine());
   
        int value = number >> positionNumber;
        bool finaleValue = (value & 1) == 1;
             
        Console.WriteLine(finaleValue);
    }
}

