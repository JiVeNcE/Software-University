using System;


class PlayWithTheDebugger
{
    static void Main(string[] args)
    {

        int a = 0;

            for (int i = 0; i < 1000; i++)

			{
                Console.WriteLine(a);
                // Playing with the debugger 
                a = a + 1; 

			}
    }
}

