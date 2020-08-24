using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Temary
{
    class Program
    {
        static void Main(string[] args)
        {

            double quantity = 10;
            double price = 100;
            double discount = 0.90;
            double cost;

            cost = quantity >= 10 ? quantity * price * discount : quantity * price;

            Console.WriteLine("full cost is: {0} {1} $", cost);

            Console.ReadKey();
        }
    }
}
