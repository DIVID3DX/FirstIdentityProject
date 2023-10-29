using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RegisterService
    {
        private DB database;

        public RegisterService(DB db)
        {
            database = db;
        }

        public bool Register(string userName, string pass) 
        {
            User user = new User(userName, pass);

            database.Users.Add(user);

            return true;
        }

    }
}
