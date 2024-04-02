using System;

namespace Activity1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string username = "Admin";
            string password = "Admin1234!";
            int attempts = 0;
            int maxAttempts = 3;

            while (attempts < maxAttempts)
            {
                Console.Write("Enter your username: \n");
                string enterUsername = Console.ReadLine();

                Console.Write("Enter your password: \n");
                string enterPassword = Console.ReadLine();

                if (enterUsername == username && enterPassword == password)
                {
                    Console.WriteLine("Login Successful");
                    break;
                }
                else
                {
                    attempts++;
                    Console.WriteLine("Incorrect Credentials. Try Again!\n(Your Attempts: " + attempts + " out of 3)\n");
                }
            }
            if (attempts == maxAttempts)
            {
                Console.WriteLine("Sorry, Login Failed.");
                Console.WriteLine("Maximum Attempts have been reached.");
            }
        }
    }
}
