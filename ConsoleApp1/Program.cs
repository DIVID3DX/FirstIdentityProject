using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LoginService loginService = new LoginService();
            RegisterService registerService = new RegisterService();
            
            Console.WriteLine("Please log in(1) or register(2):");

            int input = int.Parse(Console.ReadLine());

            if(input == 1)
            {
                Console.WriteLine("Please enter your username and password:");

                string userName = Console.ReadLine();

                string pass = Console.ReadLine();

                Console.WriteLine("Please confirm your password:");

                string passConf = Console.ReadLine();

               loginService.Login(userName, pass, passConf);
            }
            else
            {
                Console.WriteLine("Please choose a username and set your password:");

                string userName = Console.ReadLine();

                string pass = Console.ReadLine();

                registerService.Register(userName, pass);

                Console.WriteLine("You have been successfully registered.");
            }

        }
    }
}
