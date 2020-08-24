using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Temary
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = -5;

            string quadrant = (x > 0) ? ((y > 0) ? "1 quadrant" : "4 quadrant") : ((y > 0) ? "2 quadrant" : "3 quadrant");

            quadrant = x > 0 ? (y > 0 ? "1 quadrant" : "4 quadrant") : (y > 0 ? "2 quadrant" : "4 quadrant");

            quadrant = x > 0 ? y > 0 ? "1 quadrant" : "4 quadrant" : y > 0 ? "2 quadrant" : "3 quadrant";

            Console.WriteLine(quadrant);

        }
    }
}
