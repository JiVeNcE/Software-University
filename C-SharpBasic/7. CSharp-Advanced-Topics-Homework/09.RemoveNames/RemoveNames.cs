//Write a program that takes as input two lists of names and removes from the first list all names given in the second list. The input and output lists are given as words, separated by a space, each list at a separate line. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class RemoveNames
{
    static void Main()
    {     
        Console.Write("Enter first list of names : ");
        string firstLine = Console.ReadLine();
        
        Console.Write("Enter first list of names : ");
        string secondLine = Console.ReadLine();
     
        string[] firstList = firstLine.Split(' ');
        string[] secondList = secondLine.Split(' ');
        string[] newList = new string[firstList.Length];

        int i = 0;
        foreach (string word in firstList)
        {
            if (!secondList.Contains(word))
            {
                newList.SetValue(word, i);
                i++;
            }
        }   
        Console.Write("The new list is: ");
        foreach (string word in newList)
        {
            Console.Write(word + " ");
        }       
    }
}
