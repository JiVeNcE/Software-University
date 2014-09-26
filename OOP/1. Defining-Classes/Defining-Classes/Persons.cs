using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Persons
    {
        static void Main(string[] args)
        {
            Person zhivko = new Person("Zhivko", 99, "gosho@gosho.bg");
            Person ivan = new Person("Ivan", 11);

            Console.WriteLine(zhivko.ToString());
            Console.WriteLine(ivan.ToString());
        }
    }
}
