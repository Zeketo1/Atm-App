namespace AtmApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Functions fun = new Functions();

            bool condition = true;

            while(condition)
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
                        fun.checkBalance();
                        break;
                    case 2:
                        fun.depositFunds();
                        break;
                    case 3:
                        fun.withdraw();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
}   }