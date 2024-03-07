using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp
{
    internal class Functions
    {
        Random random = new Random();

        int accountBalance = 20000;
        int accountPin = 1234;

        public Functions()
        {
        }

        public void checkBalance()
        {
            Console.WriteLine("Your account balance is: {0}", accountBalance);
            Console.WriteLine("Press Enter key to return to the home page");
            Console.ReadKey();
        }

        public void depositFunds()
        {
            Console.WriteLine("How much do you want to Deposit?");
            string inputAmount = Console.ReadLine();
            int depositAmount = Convert.ToInt32(inputAmount);

            accountBalance += depositAmount;

            Console.WriteLine("Your new balance is: {0}", accountBalance);
            Console.WriteLine("Press Enter key to return to the home page");
            Console.ReadKey();
        }

        public void withdraw()
        {
            Console.WriteLine("How much do you want to Withdraw?");
            string inputAmount = Console.ReadLine();
            int withdrawAmount = Convert.ToInt32(inputAmount);
            int condition = 0;
            int trys = 2;


            while(condition < 3)
            {
                Console.Write("Enter your account pin: ");
                string pin = Console.ReadLine();
                int pin2 = Convert.ToInt16(pin);
                if (pin2 == accountPin)
                {
                    accountBalance -= withdrawAmount;
                    Console.WriteLine("Your new balance is: {0}", accountBalance);
                    Console.WriteLine("Press Enter key to return to the home page");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    if (condition == 2)
                    {
                        Console.WriteLine("Too many Invalid attempts.....");
                        Console.WriteLine("Withdrawal Failed Thieffffffffff.....");
                        break;
                    } 
                    else
                    {
                        Console.WriteLine("Invalid Pin.......Re-enter PIN.......You have {0} more trys", trys--);
                        condition++;
                    }
                }
            }

        }
    }
}
