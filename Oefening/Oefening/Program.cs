namespace Oefening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string setUserName = "testUser";
            string setPassword = "testing";
            string userName;
            string password;
            bool succes;
            int tries = 0;

            while (tries < 3)
            {
                Console.Write("Enter username: ");
                userName = Console.ReadLine();
                Console.Write("Enter password: ");
                password = Console.ReadLine();

                succes = userName == setUserName && password == setPassword;
                if (succes)
                {
                    Console.WriteLine($"Welcome {userName}.");
                    return;
                }
                tries++;
                Console.WriteLine($"Wrong password or username. {3 - tries} tries left.");
            }
        }
    }
}
