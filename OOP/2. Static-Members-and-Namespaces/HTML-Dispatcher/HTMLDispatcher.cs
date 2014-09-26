using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class HTMLDispatcher
    {
        private string tag;
        private List<string> atributes = new List<string>();
        private string innerElement;

        public HTMLDispatcher()
            : this("div")
        {
        }

        public HTMLDispatcher(string tag)
        {
            this.Tag = tag;
            //  this.innerElement=new HTMLDispatcher();
        }
        public string InnerElement
        {
            get{ return this.innerElement; }
            set{ this.innerElement = value; }
        }
        public List<string> Atributes
        {
            get{ return this.atributes; }
            set{ this.atributes = value;}
        }
        public string HTMLElement
        {
            get
            {
                string atributes = "";
                StringBuilder atributesBuilding = new StringBuilder();
                foreach (var item in this.Atributes)
                {
                    atributesBuilding.Append(" " + item);
                }
                if (atributesBuilding.ToString() != "")
                {
                    atributes = atributesBuilding.ToString() + " ";
                }
                string element = "<" + this.tag + atributes + ">" + this.innerElement + "<\\" + this.tag + ">";
                return element;               
            }
            set
            {
                this.tag = value;
            }
        }
        public string Tag
        {
            get { return this.tag; }
            set { this.tag = value; }
        }

        public void addAtribute(string atribute)
        {
            this.Atributes.Add(atribute);
        }
        public static string operator *(HTMLDispatcher element, int second)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < second; i++) { sb.Append(element.HTMLElement); }
            return sb.ToString();
        }
    }