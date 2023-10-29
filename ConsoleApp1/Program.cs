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
        static DB db = new DB();
        static LoginService loginService = new LoginService(db);
        static RegisterService registerService = new RegisterService(db);


        public static void Main(string[] args)
        {
          MainMenu();

        }

        public static void MainMenu() 
        {
            Console.WriteLine("Please log in(1) or register(2):");

            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("Please enter your username and password:");

                string userName = Console.ReadLine();

                string pass = Console.ReadLine();

                loginService.Login(userName, pass);
            }
            else
            {
                Console.WriteLine("Please choose a username and set your password:");

                string userName = Console.ReadLine();

                string pass = Console.ReadLine();

                bool hasRegistered = registerService.Register(userName, pass);

                if (hasRegistered) 
                {
                    Console.WriteLine("You have been successfully registered.");

                    MainMenu();

                }


            }

        }

    }
}
