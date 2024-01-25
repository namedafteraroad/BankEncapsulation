namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();

            Console.WriteLine("Welcome to the Bank of the Shire");

            

            myAccount.Deposit(34.3);
            myAccount.GetBalance();

            //console readline to deposit

        }
    }
}
