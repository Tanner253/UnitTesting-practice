using System;
using System.Collections;

namespace UnitTestingLab
{
    public class Program
    {
        public static int currentBalance = 5000;
        public static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Welcome to your virtual ATM:");
            Console.WriteLine($"your balance is: {currentBalance}");
            Console.WriteLine("1. Withdraw funds");
            Console.WriteLine("2. Deposit funds");
            Console.WriteLine("3. View balance");
            Console.WriteLine("4. Exit");
            string stringChoice = Console.ReadLine();
            choice = Convert.ToInt32(stringChoice);
            int caseSwitch = choice;
            switch (caseSwitch)
            {
                case 1:
                    //run function 1
                    break;
                case 2:
                    //run func2
                    break;
                case 3:
                    //run func 3
                    break;
            }

        }
        }
       
}
