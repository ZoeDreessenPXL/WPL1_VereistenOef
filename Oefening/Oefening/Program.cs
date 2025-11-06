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

            Console.Write("Enter username: ");
            userName = Console.ReadLine();
            Console.Write("Enter password: ");
            password = Console.ReadLine();

            succes = userName == setUserName && password == setPassword;
            Console.WriteLine(succes);
        }
    }
}
