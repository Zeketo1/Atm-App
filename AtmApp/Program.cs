namespace AtmApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Functions fun = new Functions();

            Atm atm = fun.Start;

            atm(20000, 1234);

            /*fun.Start();*/
        }
}   }