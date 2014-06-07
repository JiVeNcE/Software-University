//Write a method that calculates all prime numbers in given range and returns them as list of integers:

//Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line) and prints all primes in their range, separated by a comma.

using System;
using System.Collections.Generic;
using System.Linq;

    class PrimesInGivenRange
    {

        public static List<int> IsPrime(int start, int end)
    {
        List<int> primes = new List<int>();

        if (start <2)
        {
            start = 2;
        }

        for (int i = start; i <= end; i++)
        {
            bool isPrime = true;
            for (int j = 2; (j * j) <= i; j++)
            {
                if ((i % j) == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primes.Add(i);
            }
        }
        return primes;
    }
        static void Main()
        {
            Console.Write("Enter the Start number: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the End number here: ");
            int endNum = int.Parse(Console.ReadLine());

            //Invoke the IsPrime() method
            List<int> primes = IsPrime(startNum, endNum);

            //Print the list
            foreach (int prime in primes)
            {
                Console.WriteLine(prime);
            }           
        }
    }

