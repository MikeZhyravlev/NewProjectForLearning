using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2; //создаем две целочисленные переменные 

            // создаем условную конструкцию if, в условии которой проверяем a меньше b

            if (a < b)
            {
                Console.WriteLine("a < b");

            }
            else
            {
                Console.WriteLine("а не меньше b");
            }

            Console.ReadKey();
        }
    }
    
}
