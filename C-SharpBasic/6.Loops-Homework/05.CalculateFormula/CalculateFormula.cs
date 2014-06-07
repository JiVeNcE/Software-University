using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryFemaleGPS
{
    class AngryFemaleGPS
    {
        static void Main()
        {
            string readNumbers = Console.ReadLine();
            string[] num = readNumbers.Split(' ');

            int odd = 1;
            int even = 1;
            int y = 1;

            double oddSUm = 0;
            double oddMin = 0;
            double oddMax = 0;
            double EvenSum = 0;
            double EvenMax = 0;

            for (int i = 1; i > 0; i++)
            {

                int numbers = int.Parse(num[i]);

                y = (int)(numbers % 10);

                if (y % 2 == 0)
                {
                    Console.WriteLine(EvenSum); 
                }
                else
                {
                    Console.WriteLine(oddSUm); 
                }

                numbers = numbers / 10;

                if (numbers == 0 || numbers < 0)
                {
                    break;
                }
            }


        }
    }
}