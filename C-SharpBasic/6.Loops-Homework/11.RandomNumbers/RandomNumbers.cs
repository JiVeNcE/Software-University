//Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine()); 
        int max = int.Parse(Console.ReadLine());

        bool minAndMax = min <= max;
        if (minAndMax)
        {
            max += 1;
            Random random = new Random();

            for (int i = 0; i <= number; i++)
            {
                int result = random.Next(min, max); // creates numbers between min and max
                Console.Write(result);
            }
            Console.WriteLine();
        }
    }
}
