using System;

namespace lab02
{
    public class Program
    {
        public static int startingBalance = 2000;
        public static void Main(string[] args)
        {
            string rawChoice;
            Console.WriteLine("Welcome to your virtual ATM:");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. End");
            
            rawChoice = Console.ReadLine();
            int choice = Convert.ToInt32(rawChoice);
            int caseSwitch = choice;
            switch(caseSwitch)
            {
                case 1:
                    //do functions
                    break;
                case 2:
                    //do functions
                    break;
                case 3:
                    //do functions
                    break;
                case 4:
                    //do functions
                    break;
            }

            
        }
        public static int ViewBalance(int currentVal)
        {
           int currentBalance = currentVal;
           return currentBalance;
        }

        public static void ExitProgram()
        {
            return;
        }

    }
}
