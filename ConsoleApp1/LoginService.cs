namespace ConsoleApp1
{
    public class LoginService
    {
        private DB database;

        public LoginService(DB db)
        {
            database = db;
        }

        public void Login(string userName, string pass) 
        {
           User dbEntity = database.Users.FirstOrDefault(x => x.UserName == userName);

            if (dbEntity == null) 
            {
                Console.WriteLine("Username not found");
                return;
            }
            else if (dbEntity.Password != pass) 
            {
                Console.WriteLine("Incorrect password");
                return;
            }
            else 
            {
                Console.WriteLine($"Welcome, {dbEntity.UserName}");
            }

        }

    }
 

}