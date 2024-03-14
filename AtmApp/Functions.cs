using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp
{
    public delegate void Atm(int accountBalance, int accountPin);
    internal class Functions
    {
        Random random = new Random();

        /*int accountBalance = 20000;
        int accountPin = 1234;*/
        

        public Functions()
        {
        }

        public int AccountBalance { get; set; }
        public int AccountPin { get; set; }

        public void checkBalance( int accountBalance, int accountPin)
        {
            AccountBalance = accountBalance;
            AccountPin = accountPin;

            int condition = 0;
            int trys = 2;


            try
            {
                while (condition < 3)
                {
                    Console.Write("Enter your account pin: ");
                    string pin = Console.ReadLine();
                    int pin2 = Convert.ToInt32(pin);
                    if (pin2 == accountPin)
                    {
                        Console.WriteLine("Your account balance is: {0}", accountBalance);
                        Console.WriteLine("Press Enter key to return to the home page");
                        Console.ReadKey();

                        break;
                    }
                    else
                    {
                        if (condition == 2)
                        {
                            Console.WriteLine("Too many Invalid attempts.....");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Pin.......Re-enter PIN.......You have {0} more trys", trys--);
                            condition++;
                        }
                    }
                } 
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public void depositFunds( int accountBalance)
        {
            AccountBalance = accountBalance;
            Console.WriteLine("How much do you want to Deposit?");
            string inputAmount = Console.ReadLine();
            int depositAmount = Convert.ToInt32(inputAmount);

            Console.WriteLine("Are you sure you want to make this deposit : Y / N");
            string confirm = Console.ReadLine();

            try
            {
                if (confirm.ToLower() == "y")
                {
                    accountBalance += depositAmount;

                    Console.WriteLine("Your new balance is: {0}", accountBalance);
                    Console.WriteLine("Press Enter key to return to the home page");
                    Console.ReadKey();
                }
                else if (confirm.ToLower() == "n")
                {
                    Console.WriteLine("Your deposit has been cancelled");
                    Console.WriteLine("Press Enter key to return to the home page");
                    Console.ReadKey();
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void withdraw(int accountBalance, int accountPin)
        {
            AccountBalance = accountBalance;
            AccountPin = accountPin;
            Console.WriteLine("How much do you want to Withdraw?");
            string inputAmount = Console.ReadLine();
            int withdrawAmount = Convert.ToInt32(inputAmount);
            int condition = 0;
            int trys = 2;

            try
            {
                while(condition < 3)
                {
                    Console.Write("Enter your account pin: ");
                    string pin = Console.ReadLine();
                    int pin2 = Convert.ToInt32(pin);
                    if (pin2 == accountPin)
                    {
                        if (accountBalance < withdrawAmount)
                        {
                            Console.WriteLine("Insufficient Funds");
                            break;
                        } else
                        {
                            accountBalance -= withdrawAmount;
                            Console.WriteLine("Your new balance is: {0}", accountBalance);
                            Console.WriteLine("Press Enter key to return to the home page");
                            Console.ReadKey();
                            break;
                        }
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

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public void Start()
        {
            bool condition = true;


            while (condition)
            {
                Console.WriteLine("1. Check account Balance");
                Console.WriteLine("2. Deposit Funds");
                Console.WriteLine("3. Withdraw Cash");
                Console.WriteLine("4. Transfer Money");

                string input = Console.ReadLine();
                int choice = Convert.ToInt32(input);

                switch (choice)
                {
                    case 1:
                        checkBalance();
                        break;
                    case 2:
                        depositFunds();
                        break;
                    case 3:
                        withdraw();
                        break;
                    case 4:
                        Console.WriteLine("STILL UNDER CONSTRUCTION...........");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        private void withdraw()
        {
            throw new NotImplementedException();
        }

        private void depositFunds()
        {
            throw new NotImplementedException();
        }

        private void checkBalance()
        {
            throw new NotImplementedException();
        }
    }
}
