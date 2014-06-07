//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;

class ComparingFloats
{
    static void Main()
    {
        float firstA = 5.3f;
        float firstB = 6.01f;
        bool result = (Math.Abs(firstA - firstB) < 0.000001);

        double secondA = 5.00000001;
        double secondB = 5.00000003;
        bool result2 = (Math.Abs(secondA - secondB) < 0.000001);

        decimal thirdA = -0.0000007m;
        decimal thirdB = 0.0000007m;
        bool result3 = (Math.Abs(thirdA - thirdB) > 0.000001m);

        double fourA = -4.999999;
        double fourB = -4.999998;
        bool result4 = (Math.Abs(fourA - fourB) == 0.000001);

        double fiveA =  4.999999;
        double fiveB = -4.999999;
        bool result5 = (Math.Abs(fiveA - fiveB) == 0.000001);


        Console.WriteLine("Are the numbers {0} and {1} equal: {2}: ", firstA, firstB, result);
        Console.WriteLine("Are the numbers {0} and {1} equal: {2}: ", secondA, secondB, result2);
        Console.WriteLine("Are the numbers {0} and {1} equal: {2}: ", thirdA, thirdB, result3);
        Console.WriteLine("Are the numbers {0} and {1} equal: {2}: ", fourA, fourB, result4);
        Console.WriteLine("Are the numbers {0} and {1} equal: {2}: ", fiveA, fiveB, result5);

    }
}
