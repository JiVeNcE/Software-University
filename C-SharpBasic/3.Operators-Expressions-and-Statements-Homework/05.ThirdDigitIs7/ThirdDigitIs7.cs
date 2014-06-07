//Write an expression that checks for given integer if its third digit from right-to-left is 7. Examples:

using System;

class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            Console.Write("Write your number here : ");

            int number = int.Parse(Console.ReadLine());


            int divideOn100 = number / 100;
            int divideOn10 = divideOn100  % 10;

            bool thirdNumber = divideOn10 == 7;

            Console.WriteLine("The third digir from right-to-left is 7 : {0}", thirdNumber);
        }
    }
