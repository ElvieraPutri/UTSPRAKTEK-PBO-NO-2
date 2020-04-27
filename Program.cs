using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTSPBONoMer2
{
    class Program
    {
        static void Main(string[] args)
        {
            RetaiItem[] item = new RetaiItem[3];

            item[0] = new RetaiItem("Jacket", 12, 59.95);
            item[1] = new RetaiItem("Jeans", 40, 34.95);
            item[2] = new RetaiItem("Shirt", 20, 24.95);

            Console.WriteLine("======================================================");
            Console.WriteLine("\n \t\tDescription\tUnits On Hand\tPrice\n");
            Console.WriteLine("======================================================");
            for (int i = 0; i < item.Length; i++)
            {
                Console.WriteLine("\n Item " + (i + 1) + "\t\t" + item[i].getDescription() + "\t\t" + item[i].getUnitsOnHand() + "\t\t" + item[i].getPrice() + "\n");
            }
            Console.WriteLine("======================================================");
            Console.ReadKey();
        }
    }
}
