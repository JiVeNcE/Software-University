//Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 

using System;

    class PrimeChecker
    {
        static bool Primecheck(long IsPrime)
        {
            long divider = 2;
            long maxDivider = (long)Math.Sqrt(IsPrime);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (IsPrime % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            return prime;   
        }

        static void Main()
        {
            Console.Write("Enter the number here: ");
            long num = long.Parse(Console.ReadLine());

            Console.WriteLine(Primecheck(num));
        }
    }

