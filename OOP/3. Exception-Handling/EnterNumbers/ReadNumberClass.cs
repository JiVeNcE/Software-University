using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReadNumberClass
    {
        public static int ReadNumber(int start, int end) 
        {

            int num = int.Parse(Console.ReadLine());

            if ( num <= start || num > end)
            {
                throw new ArgumentException("The number is outside of the requested range!");
            }
            return num;
        }

        static void Main()
        {
            int counter = 0;
            int start = 1;

            while (counter < 10)
            {
                try
                {
                    int curNumber = ReadNumber(start, 100);

                    if (curNumber > start)
                    {
                        start = curNumber;
                    }

                    counter++;
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine("{0}Repeat your input please!", ex.Message);
                }
                catch (Exception exs)
                {
                    Console.WriteLine("{0}Repeat your input please!", exs.Message);
                }

            }       
        }
    }
