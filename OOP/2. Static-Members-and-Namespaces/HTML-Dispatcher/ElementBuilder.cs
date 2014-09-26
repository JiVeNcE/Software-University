using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class HTMLBuilder
    {
        public static string CreateImage(string imageSource, string alt, string title)
        {

            HTMLDispatcher el = new HTMLDispatcher("img");
            el.addAtribute("href=\"" + imageSource + "\"");
            el.addAtribute("alt=\"" + alt + "\"");
            el.InnerElement = title;

            return el.HTMLElement;
        }

        public static string CreateURL(string url, string title, string text) { return ""; }
        public static string CreateInput(string inputType, string name, string value) { return ""; }
    }