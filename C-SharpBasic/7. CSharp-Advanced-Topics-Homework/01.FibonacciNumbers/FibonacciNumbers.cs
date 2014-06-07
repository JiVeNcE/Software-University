//Define a method Fib(n) that calculates the nth Fibonacci number.

using System;

    class FibonacciNumbers
    {

        public static int Fibonacci(int fib)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i <= fib; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            Console.Write("Enter you number here: ");
            int num = int.Parse(Console.ReadLine());

            
                Console.Write(Fibonacci(num));
            
            Console.WriteLine();
        }

    
        
    }
