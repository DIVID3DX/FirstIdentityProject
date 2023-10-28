using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RegisterService
    {
        private DB databaZEN = new DB();
        public void Register(string userName, string pass) 
        {
            User user = new User(userName, pass);

            databaZEN.Users.Add(user);
        }

    }
}
