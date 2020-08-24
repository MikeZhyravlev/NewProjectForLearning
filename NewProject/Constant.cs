using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpStarter
{
    class Constant
    {
        static void Main()
        {
            // Создаем константу с именем pi, типа double и значением 3.141

            const double pi = 3.141;

            Console.WriteLine(pi);

            // Присваиваем не корректное значение 
            //pi = 2.6123123123;

            Console.WriteLine(pi);
            Console.ReadKey();
        }
    }
}
