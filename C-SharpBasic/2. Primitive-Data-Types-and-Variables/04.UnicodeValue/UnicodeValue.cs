﻿//Declare a character variable and assign it with the symbol that has Unicode code 72, and then print it. Hint: first, use the Windows Calculator to find the hexadecimal representation of 72. The output should be “H”.

using System;

class UnicodeValue
{
    static void Main()
    { 
        decimal Symbol = 0x2A;

        Console.WriteLine((char)Symbol);
    }

}

