using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Functions
    {
      public static void first()
      {
            // This is the first method. In this method program will ask user about the balance they 
            // have & how much they want to withdraw. Simple Happy Path.
            Console.WriteLine("Welcome to Good ATM where we dont charge you overdraft fee");
            Console.WriteLine("Please enter your balance");
            int balance = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the amount you want to withdraw");
            int withdraw = Int32.Parse(Console.ReadLine());
            var amount = (balance - withdraw);
            Console.WriteLine("Please take $ " + withdraw + " Your remaining balance is now " + amount);
      }

        public static void second()
        {
            // This is the second method. In this method program will ask user how much balance they have
            // & how much they want to withdraw. If the withdraw is more then balance then program will ask
            // please confirm if you want to withdraw more then your balance. If user says yes then display message
            // if user says no then display Good Bye.
            Console.WriteLine("Welcome to Good ATM where we dont charge you overdraft fee");
            Console.WriteLine("Please enter your balance");
            int balance = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the amount you want to withdraw");
            int withdraw = Int32.Parse(Console.ReadLine());
            var amount = (balance - withdraw);
            bool overdraft;

            if (withdraw > balance)
            {
                overdraft = true;
                Console.WriteLine("Are you sure you want to withdraw more than your balance? Enter Yes or No");
                string response = Console.ReadLine();

                if (response.Equals("Yes"))
                {
                    Console.WriteLine("Please take $ " + withdraw + " Your remaining balance is now " + amount);
                    Console.WriteLine("Thank you for using Good ATM");
                }
                if (response.Equals("No")) 
                {
                    Console.WriteLine("Thank you for using Good ATM");
                }
                

            }

        }

    }
}
