using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authentication.Data;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mgr = new UserManager(Properties.Settings.Default.ConStr);
            //mgr.AddUser("avrumi@lit.com", "litrulesnot");

            //User u = mgr.GetUser("avrumi@lit.com", "litrulesnot");

            Console.WriteLine("Enter a username");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password");
            string password = "";
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }

                password += key.KeyChar;
                Console.Write("*");
            }

            Console.WriteLine();
            User u = mgr.GetUser(username, password);
            if (u != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!");
            }
            
            Console.ReadKey(true);


        }
    }
}
