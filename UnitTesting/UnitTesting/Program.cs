using System;

namespace UnitTesting
{
    public class Program
    {
        public static decimal totalBalance = 3500;
        public static void Main(string[] args)
        {
            try
            {
                //decimal totalBalance = 3500;
                Console.WriteLine("Welcome to the VirtuATM");
                bool runApp = true;
                //decimal totalBalance = 3500;
                do
                {
                    Console.WriteLine("Please select an option 1-4, You must pick a numerical value");

                    Console.WriteLine("1. View balance");

                    Console.WriteLine("2. Withdraw Money");

                    Console.WriteLine("3. Deposit Money");

                    Console.WriteLine("4. Exit ATM");

                    string userInput = Console.ReadLine();
                    int convertStgToInt = Convert.ToInt32(userInput);
                    if (convertStgToInt == 1)
                    {
                        Console.WriteLine($"Your Current Balance is {totalBalance}");                       

                    }
                    else if (convertStgToInt == 2)
                    {
                        Console.WriteLine($"Enter an amount you would like to withdraw, your current balance is {totalBalance}");
                        string userWithdraw = Console.ReadLine();
                        decimal withdrawnAmt = Convert.ToInt32(userWithdraw);
                        WithdrawAmt(withdrawnAmt, totalBalance);
                    }
                    else if (convertStgToInt == 3)
                    {
                        Console.WriteLine($"Enter an amount you would like to deposit, your current balance is {totalBalance}");
                        string userDeposit = Console.ReadLine();
                        decimal depositAmt = Convert.ToInt32(userDeposit);
                        DepositAmt(depositAmt, totalBalance);
                        
                    }
                    else
                    {
                            
                    }

                } while (runApp);

            } catch (Exception e)
            {
                Console.WriteLine("Sorry, what you entered must be a numerical value");
                Console.WriteLine(e);

            } finally
            {
                Console.WriteLine("Enjoy your day");
            }
        }

        public static string WithdrawAmt(decimal withdrawnAmt, decimal totalBalance)
        {
            if (withdrawnAmt > totalBalance)
            {
                return "You cannot withdraw more than your total balance";

            } else
            {
                totalBalance = totalBalance - withdrawnAmt;
                Console.WriteLine($"You new balance is now {totalBalance}");
                return Convert.ToString(totalBalance);

            }

        }

        public static string DepositAmt(decimal depositAmt, decimal totalBalance)
        {
            if (depositAmt > 0)
            {

                totalBalance = totalBalance + depositAmt;
                Console.WriteLine($"You new balance is now {totalBalance}");
                return Convert.ToString(totalBalance);

            }
            else
            {
                return "You cannot deposit less than zero!";

            }
            
        }

    }
}
