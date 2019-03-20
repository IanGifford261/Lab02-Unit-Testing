using System;


namespace UnitTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the VirtuATM");
            bool runApp = true;
            decimal totalBalance = 3500;
            do
            {
                Console.WriteLine("Please select an option 1/2/3/4");
                Console.WriteLine("1. View balance");
                Console.WriteLine("2. Withdraw Money");
                Console.WriteLine("3. Deposit Money");
                Console.WriteLine("4. Exit ATM");
                string userInput = Console.ReadLine();
                int convertStgToInt = Convert.ToInt32(userInput);
                if (convertStgToInt == 1)
                {
                    Console.WriteLine($"Your Current Balance is {totalBalance}");
                }else if (convertStgToInt == 2)
                {
                    Console.WriteLine($"Select an amount you would like to withdraw, your current balance is {totalBalance}");
                    string userWithdraw = Console.ReadLine();
                    decimal withdrawnAmt = Convert.ToInt32(userWithdraw);
                    
                }

            } while (runApp);

        }

        public static decimal withdrawAmt() 
    }
}
