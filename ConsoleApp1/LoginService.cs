namespace ConsoleApp1
{
    public class LoginService
    {
        public void Login(string userName, string pass, string confPass) 
        {
           
            int retryCount = 0;

            while (confPass != pass && retryCount < 3)
            {
                Console.WriteLine("The passwords do not match! Try again.");

                retryCount++;

                pass = Console.ReadLine();

                confPass = Console.ReadLine();

            }

            if (retryCount < 3)
            {
                Console.WriteLine($"Hello {userName}!");
            }
            else
            {
                Console.WriteLine("Entry failed!");
            }




        }

    }
 

}