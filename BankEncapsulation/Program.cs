using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();

            Console.WriteLine("Welcome to the Bank of the Shire");
            Console.WriteLine("Enter deposit amount");
            var userDeposit = double.Parse(Console.ReadLine());
            

            myAccount.Deposit(userDeposit);
            Console.WriteLine($"{myAccount.GetBalance()}");
            

            //Create a new public class named BankAccount


            //In your BankAccount class, create the following:
                //A private field of type double named **balance** with a value of 0
                //Define a method named Deposit that will accept a double and store that value in the balance field
                //Define a method named GetBalance that will return the amount stored in the balance field
            //In the main method of your application, create a new instance of the BankAccount class.
            //Allow the user of the application to Deposit money and retrieve their balance through the console.
            
        }
    }
}
