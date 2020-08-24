using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Autentication
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "Admin";
            string password = "Password";
            Console.Write("Enter login: ");

            string userLogin = Console.ReadLine();

            if (login == userLogin)
            {
                Console.Write("Enter password: ");
                string userPassword = Console.ReadLine();

                if (password == userPassword)
                {
                    Console.WriteLine("Hello {0}, you are entered to system as.", userLogin);
                }

                else
                {
                    Console.WriteLine("Incorrect password");
                }
            }
            else
            {
                Console.WriteLine("No such user");
            }
            Console.ReadKey();
        }
    }
}
