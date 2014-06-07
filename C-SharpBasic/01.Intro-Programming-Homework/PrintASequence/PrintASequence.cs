using System;




class Program
{
    static void Main()
    {

        int multiplier = 1;
        for (int i = 2; i < 12; i++)
        {
            Console.WriteLine(i * multiplier);
            multiplier = multiplier * -1;
        }

    }
}
