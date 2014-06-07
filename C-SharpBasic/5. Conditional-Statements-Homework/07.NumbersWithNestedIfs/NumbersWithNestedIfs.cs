//Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality

using System;

class NumbersWithNestedIfs
    {
        static void Main()
        {
            Console.Write("Enter here first number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Enter here second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("Enter here third number: ");
            double thirdNum = double.Parse(Console.ReadLine());

            if (firstNum > secondNum && firstNum > thirdNum)
            {
                Console.WriteLine("{0}{1}{2}", firstNum, thirdNum, secondNum);
            }
            else
            {
                if(secondNum > firstNum && secondNum > thirdNum  )
                {
                    Console.WriteLine("{0}{1}{2}", secondNum, thirdNum, firstNum);
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}", thirdNum, secondNum, firstNum);
                }
            }
        }
    }
