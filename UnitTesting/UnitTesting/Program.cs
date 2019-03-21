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
                Console.WriteLine("Welcome to the VirtuATM");
                bool runApp = true;

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

                    }
                    else if (convertStgToInt == 2)
                    {
                        Console.WriteLine($"Enter an amount you would like to withdraw, your current balance is {totalBalance}");
                        string userWithdraw = Console.ReadLine();
                        decimal withdrawnAmt = Convert.ToInt32(userWithdraw);
                        //WithdrawAmt(withdrawnAmt, totalBalance);
                    }
                    else if (convertStgToInt == 3)
                    {
                        Console.WriteLine($"Enter an amount you would like to deposit, your current balance is {totalBalance}");
                        string userDeposit = Console.ReadLine();
                        decimal depositAmt = Convert.ToInt32(userDeposit);
                        //DepositAmt(depositAmt, totalBalance)
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
                decimal newBalance;
                newBalance = withdrawnAmt - totalBalance;
                return Convert.ToString(newBalance);
            }

        }

        public static string DepositAmt(decimal depositedAmt, decimal totalBalance)
        {
            if (depositedAmt > 0)
            {
                decimal newBalance;
                newBalance = depositedAmt + totalBalance;
                return Convert.ToString(newBalance);
            } else
            {
                return "You cannot deposit less than zero!";
            }
            
        }

    }
}
