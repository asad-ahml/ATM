using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Good ATM where we dont charge you overdraft fee");
            Console.WriteLine("Please enter your balance");
            int balance = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the amount you want to withdraw");
            int withdraw = Int32.Parse(Console.ReadLine());
            var amount = (balance - withdraw);
            Console.WriteLine("Please take $ " + withdraw + " Your remaining balance is now " + amount);


            Console.ReadLine();

        }
    }
}
