using System;

namespace lab02
{
    public class Program
    {
        public static int startingBalance = 2000;
        public static int currentBalance = startingBalance;
        public static bool doWhileTrue = true;
        public static void Main(string[] args)
        {

            
            do 
            {   int choice = GetSelection();
                int caseSwitch = choice;
                switch (caseSwitch)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine(ViewBalance());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        // GetSelection();

                        break;
                    case 2:
                        try
                        {
                            Console.Write("How much money would you like to Withdraw?");
                            string withdrawlAmount = Console.ReadLine();
                            int intWithdrawl = Convert.ToInt32(withdrawlAmount);

                            Console.WriteLine($"your new balance is {currentBalance} - {intWithdrawl} =");

                            Console.WriteLine(RemoveFunds(currentBalance, intWithdrawl));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        // GetSelection();

                        break;
                    case 3:
                        try { 
                        Console.Write("How much money would you like to Deposit?");
                        string intInput = Console.ReadLine();
                        int input = Convert.ToInt32(intInput);
                        AddFunds(currentBalance, input);
                        Console.WriteLine($"your new balance is {currentBalance} + {input} = ");
                        currentBalance = currentBalance + input;
                        Console.WriteLine($"{currentBalance}");
                        }

                         catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        //   GetSelection();

                        break;
                    case 4:
                        try
                        {
                            ExitProgram();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.WriteLine("program is complete");
                            Console.ReadLine();
                        }
                        break;
                }
                

            }
            while (doWhileTrue) ;

            
        }
        
        public static int GetSelection()
        {
            string rawChoice;
            Console.WriteLine("Welcome to your virtual ATM:");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. End");

            rawChoice = Console.ReadLine();
            int choice = Convert.ToInt32(rawChoice);
            if(choice < 0 && choice > 4)
            {
                GetSelection();
            }
            return choice;
        }
        /// <summary>
        /// will write the current ATM balance to program
        /// </summary>
        /// <returns>intiger value of balance</returns>
        public static int ViewBalance()
        {
           int viewBalance = currentBalance;
           return viewBalance;
        }
        /// <summary>
        /// adds funds to the existing current balance
        /// </summary>
        /// <param name="currentBalance">the current ATM balance</param>
        /// <param name="input">The number equivilent to the funds the user would like to add</param>
        /// <returns>new current balance</returns>
        public static string AddFunds(int currentBalance, int input)
        {
            string strResult;
            if (input <= 0)
            {
                strResult = "Please enter a number greater than 0";
                

            }
            else
            {

                currentBalance = currentBalance + input;
                strResult = currentBalance.ToString();


              
            }
            return strResult;
        }
        /// <summary>
        /// will take current balance and subtract withdrawl amount
        /// </summary>
        /// <param name="currentValue">current balance</param>
        /// <param name="withdrawl">the amount being subtracted from total</param>
        /// <returns>the new balance after math operation</returns>
        public static string RemoveFunds(int currentValue, int withdrawl)
         {
            string strResult;
           
            if (currentBalance >= withdrawl)
            {
                currentBalance = currentValue - withdrawl;
                strResult = currentBalance.ToString();
                return strResult;
            }
            else if (currentBalance < withdrawl)
            {
                return strResult = "please enter a valid selection";


            }else
            {
                return "string";
            }
            
          
        }
        /// <summary>
        /// allows the user to exit the program
        /// </summary>
        public static void ExitProgram()
        {
            doWhileTrue = false;
            return;
        }

    }
}
