//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//•	If the score is between 1 and 3, the program multiplies it by 10.
//•	If the score is between 4 and 6, the program multiplies it by 100.
//•	If the score is between 7 and 9, the program multiplies it by 1000.
//•	If the score is 0 or more than 9, the program prints “invalid score”.

using System;

class MultipleLabels
{
    static void Main()
    {
        Console.Write("Please enter bonus score in the range [1…9] : ");
        int cardsNum = int.Parse(Console.ReadLine());

        if (cardsNum > 0 && cardsNum < 10)
        {
          if(cardsNum >=1 && cardsNum <=3)
          {
              Console.WriteLine("{0}", cardsNum * 10);
          }
             else if (cardsNum >=4 && cardsNum <=5)
          {
              Console.WriteLine("{0}", cardsNum * 100);
          }
             else if (cardsNum >=7 && cardsNum <=9)
          {
              Console.WriteLine("{0}", cardsNum * 1000);
          } 
        }
        else
        {
            Console.WriteLine("Invalid score!");
        }
    }
}