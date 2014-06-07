//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//•	Prints on the console the number in reversed order: dcba (in our example 1102).
//•	Puts the last digit in the first position: dabc (in our example 1201).
//•	Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0. Examples:


using System;

class FourDigitNumber
{
    static void Main(string[] args)
    {
        Console.Write("write your four-digit number in format abcd (e.g. 2011) here : ");

        int number = int.Parse(Console.ReadLine());

        int fourDigit = number % 10;

        int thirhtNumber = number / 10;
        int thirhtDigit = thirhtNumber % 10;

        int secondNumber = number / 100;
        int secondDigit = secondNumber % 10;

        int firstNumber = number / 1000;
        int firstDigit = firstNumber % 10;

        int sum = fourDigit + thirhtDigit + secondDigit + firstDigit;   

        Console.WriteLine("The sum of the digits in format abcd : {0} + {1} + {2} + {3} is {4} ,", firstDigit, secondDigit, thirhtDigit, fourDigit, sum);
        Console.WriteLine("The reversed order in format dabc on your number is : {0}{1}{2}{3} ", thirhtDigit, fourDigit, secondDigit, firstDigit);
        Console.WriteLine("Puts the last digit in the first position : {0}{1}{2}{3}", fourDigit, firstDigit, secondDigit, thirhtDigit);
        Console.WriteLine("Exchanges the second and the third digits : {0}{1}{2}{3}", firstDigit, thirhtDigit, secondDigit, fourDigit);
    }
}

