using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Result
    {
        static void Main(string[] args)
        {
            HTMLDispatcher htmlElementDiv = new HTMLDispatcher();
            Console.WriteLine(htmlElementDiv.HTMLElement);

            htmlElementDiv.addAtribute("href=\"www.softuni.bg\"");
            Console.WriteLine(htmlElementDiv.HTMLElement);
            HTMLDispatcher innerHTMLP = new HTMLDispatcher("p");
            innerHTMLP.InnerElement = "Some Text";
            Console.WriteLine(innerHTMLP.HTMLElement);

            htmlElementDiv.addAtribute("class=\"links\"");
            htmlElementDiv.InnerElement = innerHTMLP.HTMLElement;
            Console.WriteLine(htmlElementDiv * 2);

            Console.WriteLine(HTMLBuilder.CreateImage("www.softuni.bg", "OOP", "Class"));
        }
    }
