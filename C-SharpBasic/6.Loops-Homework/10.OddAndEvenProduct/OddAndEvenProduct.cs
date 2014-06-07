//You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;
using System.Linq;


class OddAndEvenProduct

{
    static void Main()
    {
       
        string readNumbers = Console.ReadLine();
        string[] num = readNumbers.Split(' ');

        int odd = 1;
        int even = 1;
        
        for (int i = 0; i < num.Length ; i++)
        {

            int numbers = int.Parse(num[i]);

            if (numbers % 2 == 0 || i == 0)
            {
                odd *= numbers;
            }
            else
            {
                even *= numbers;
            }
        }
        if (odd == even)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = " + odd);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = " + odd);
            Console.WriteLine("even_product = " + even);
        }
       

    }
}

