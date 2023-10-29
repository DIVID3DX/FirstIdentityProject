using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DB
    {
        public List<User> Users { get; set; }

        public DB() 
        { 
          Users = new List<User>();
        }
    }
}
