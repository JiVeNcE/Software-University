//Write a program that finds the biggest of five numbers by using only five if statements. 

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter here first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Enter here second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        Console.Write("Enter here third number: ");
        double thirdNum = double.Parse(Console.ReadLine());
        Console.Write("Enter here fourth  number: ");
        double fourthNum = double.Parse(Console.ReadLine());
        Console.Write("Enter here fifth number: ");
        double fifthNum = double.Parse(Console.ReadLine());
     

       
        if ( firstNum > secondNum && thirdNum < firstNum && fourthNum < firstNum && fifthNum < firstNum )
        {
            Console.WriteLine("The bigger number is: {0}", firstNum);
        }

        else if (secondNum > thirdNum && fourthNum < secondNum && fifthNum < secondNum && secondNum > firstNum )
        {
            Console.WriteLine("The bigger number is: {0}", secondNum);
        }
        else if (thirdNum > fourthNum && thirdNum > fifthNum && thirdNum > secondNum && thirdNum > firstNum)
        {
            Console.WriteLine("The bigger number is: {0}", thirdNum);
        }     
        else if (fourthNum > fifthNum && fourthNum > firstNum && fourthNum > secondNum && fourthNum > thirdNum)
        {
            Console.WriteLine("The bigger number is: {0}", fourthNum);

        }
        else
        {
            Console.WriteLine("The bigger number is: {0}", fifthNum);
        }
    }

}
