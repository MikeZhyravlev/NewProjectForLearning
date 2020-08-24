using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Temary
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            double b = 0.0;
            int max;

            max = (int)((a > b) ? a : b);

            // or

            max = (a > b) ? a : (int)b;

            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}
