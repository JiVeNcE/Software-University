using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Shop
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, string manufacturer = null, string processor = null, string ram = null, string graphicCard = null,
            string hdd = null, string screen = null, Battery battery = null)
            : this(model, price)
       {
           this.Manufacturer = manufacturer;
           this.Processor = processor;
           this.Ram = ram;
           this.GraphicCard = graphicCard;
           this.Hdd = hdd;
           this.Screen = screen;
           this.Battery = battery;
       }

        public string Model
        {
            get {return this.model; }
            set 
           {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The input information is missing!");
                }
               this.model = value;
           }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Inavlid value for manufactured!");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Inavlid value for processor!");
                }
                this.processor = value;
            }
        }
        public string Ram
        {
            get { return this.ram; }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Inavlid value for ram!");
                }
                this.ram = value;
            }
        }
        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Inavlid value for screen!");
                }
                this.screen = value;
            }
        }
        public string GraphicCard
        {
            get { return this.graphicCard; }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Inavlid value for Graphic Card!");
                }
                this.graphicCard = value;
            }
        }
        public string Hdd
        {
            get { return this.hdd; }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Inavlid value for Hdd!");
                }
                this.hdd = value;
            }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The argument must not to be negative or zero.");
                }
                this.price = value;
            }
        }
        
        public override string ToString()
        {
            StringBuilder laptopsStr = new StringBuilder();
            laptopsStr.AppendLine("model: " + this.model);
            if (this.Manufacturer != null)
                {
                    laptopsStr.AppendLine("Manufactured: " + this.Manufacturer);
                }
                if(this.Processor != null)
                {
                    laptopsStr.AppendLine("Processor: " + this.Processor);
                }
                if(this.Ram != null)
                {
                    laptopsStr.AppendLine("Ram: " + this.Ram);
                }
                if(this.Screen != null)
                {
                    laptopsStr.AppendLine("Screen: " + this.Screen);
                }
                if(this.GraphicCard != null)
                {
                    laptopsStr.AppendLine("Graphic Card: " + this.GraphicCard);
                }
                if(this.Battery != null)
                {
                    laptopsStr.AppendLine("Battery: " + this.Battery.ToString());
                }
                if(this.Hdd != null)
                {
                    laptopsStr.AppendLine("Hdd: " + this.Hdd);
                }
               
                laptopsStr.AppendLine("Price: " + this.Price);    
    
                return laptopsStr.ToString();
        }
    }
}
