using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********HBL**********");
            Console.WriteLine(":: Login Page ::");
            

            string userName = null, password = null;
            Console.Write("Username");
            userName = Console.ReadLine();

            if (userName != "")
            {
                Console.Write("Password");
                password = Console.ReadLine();
            }

            if (userName == "Ahsan" && password == "123")
            {
                Console.WriteLine("TO Do : Menu Here");

            }

            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
