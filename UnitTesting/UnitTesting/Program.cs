using System;

namespace UnitTesting
{
    public class Program
    {
        /// <summary>
        /// Main method that runs all menu options and calls the helper methods to do the math to modify the totalBalance
        /// </summary>
        public static decimal totalBalance = 3500;
        
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the VirtuATM");
                bool runApp = true;
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
                        WithdrawAmt(withdrawnAmt);
                    }
                    else if (convertStgToInt == 3)
                    
                    {
                        Console.WriteLine($"Enter an amount you would like to deposit, your current balance is {totalBalance}");
                        string userDeposit = Console.ReadLine();
                        decimal depositAmt = Convert.ToInt32(userDeposit);
                        DepositAmt(depositAmt);
                        
                    }
                    else
                    {
                        Console.WriteLine("You've chosen to exit the console, Enjoy your day :)");
                        //I learned of this Brute force method from Jamilah McWilliams the night TA, It was late and I needed help
                        Environment.Exit(0);

                    }

                } while (runApp);

            } catch (Exception e)
            {
                Console.WriteLine("Sorry, what you entered must be a numerical value");
                Console.WriteLine(e.Message);

            } finally
            {
                Console.WriteLine("Enjoy your day");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Method to withdraw (subtract) user specified amount from the totalBalance
        /// </summary>
        /// <param name="withdrawnAmt">This is the users input to withdraw from the total</param>
        /// <param name="totalBalance">This is just the global variable declared outside the Main Method</param>
        /// <returns>Error for over draw or a new balance</returns>
        public static string WithdrawAmt(decimal withdrawnAmt)
        {
            if (withdrawnAmt > totalBalance)
            {
                Console.WriteLine("You cannot withdraw more than your total balance");
                return "Please enter an amount below your total balance";
                
            }
            else 
            {
                //Jamilah McWilliams Helped me refactor this math to modify totalBalance
                totalBalance = totalBalance - withdrawnAmt;
                Console.WriteLine($"You new balance is now {totalBalance}");
                return Convert.ToString(totalBalance);

            }

        }
        /// <summary>
        /// Method to Deposit (add) user specified amount to the totalBalance
        /// </summary>
        /// <param name="depositAmt">This is the users input to deposit an amount the total</param>
        /// <returns>The total balance if input is greater than zero, otherwise it stops the method and returns to main menu</returns>
        public static string DepositAmt(decimal depositAmt)
        {
            if (depositAmt > 0)
            {
                //Jamilah McWilliams Helped me refactor this math to modify totalBalance
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
