namespace vereistenAnalyse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "Administrator";
            string password = "P@ssw0rd";

            Console.Write("Username: ");
            string inputUser = Console.ReadLine();

            Console.Write("Password: ");
            string inputPassword = Console.ReadLine();

            if (inputUser == userName && inputPassword == password)
            {
                return;
            }
        }
    }
}
