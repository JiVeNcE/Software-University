//Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). 


using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Write your  number here : ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

       
        if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 ==0)    
        {
            Console.WriteLine("False");
        }
        else
        {
             Console.WriteLine("True");
        }
    }
}
