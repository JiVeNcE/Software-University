using System;

namespace Laptop_Shop
{
    class LaptopShop
    {
        static void Main()
        {
            Battery lion = new Battery("Li-Ion, 4-cells, 2550 mAh");
            Battery nicd = new Battery("Ni-Cd", (float)4.5);
            Laptop lpt_second = new Laptop("Aspire E3-111-C5GL", (decimal)259.49);
            Laptop lpt_third = new Laptop("Acer some model", (decimal)1567.43, battery: nicd, processor: "3.2 GHz", ram: "16 GB");

            Console.WriteLine();
            Console.WriteLine(lpt_second.ToString());
            Console.WriteLine();
            Console.WriteLine(lpt_third.ToString());
        }
    }
}