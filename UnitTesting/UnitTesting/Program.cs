using System;


namespace UnitTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool runApp = true;
            decimal initialBalance = 3500;
            do
            {
                Console.WriteLine("Welcome to the VirtuATM");
                Console.WriteLine("Please select an option 1/2/3/4");
                Console.WriteLine("1. View balance");
                Console.WriteLine("2. Withdraw Money");
                Console.WriteLine("3. Deposit Money");
                Console.WriteLine("4. Exit ATM");
                string userInput = Console.ReadLine();
            } while (true);

            



        }

        public static decimal viewBalance() 
    }
}
