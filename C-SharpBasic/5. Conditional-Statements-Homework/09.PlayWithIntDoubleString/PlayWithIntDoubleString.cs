//Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement. 

using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.Write(" 1 --> int \n 2 --> double \n 3 --> string \nPlease choose a type: ");
        int choose = int.Parse(Console.ReadLine());

        if (choose == 1)
        {
            Console.Write("Please enter a int : ");
            int numberInt = int.Parse(Console.ReadLine());
            Console.WriteLine(numberInt + 1);
        }
        else if (choose == 2)
        {
            Console.Write("Please enter a double :");
            double numberDouble = double.Parse(Console.ReadLine());
            Console.WriteLine(numberDouble + 1);
        }
        else if (choose == 3)
        {
            Console.Write("Please enter a string :");
            string variableString = Console.ReadLine();
            Console.WriteLine(variableString + "*");
        }
        else
        {
            Console.WriteLine("Wrong number! Try again.");
        }  
    }
}

