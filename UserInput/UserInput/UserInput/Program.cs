using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Username: ");
            string userName = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.WriteLine($"Username: {userName}");
            Console.WriteLine("Password: " + password);
        }
    }
}
