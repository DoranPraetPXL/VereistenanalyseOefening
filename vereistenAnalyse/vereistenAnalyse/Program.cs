namespace vereistenAnalyse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "Administrator";
            string password = "P@ssw0rd";
            int attempts = 0;

            while (attempts < 3)
            {
                Console.Write("Username: ");
                string inputUser = Console.ReadLine();

                Console.Write("Password: ");
                string inputPassword = Console.ReadLine();

                if (inputUser == userName && inputPassword == password)
                {
                    return;
                }
                attempts++;
                Console.WriteLine($"Wrong login, {3-attempts} attempts left.");
            }
            Console.WriteLine("To many attempts. Acces denied.");
          
        }
    }
}
