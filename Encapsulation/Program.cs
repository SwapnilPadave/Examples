using System;

namespace Encapsulation
{
    public class BankAccount
    {
        private string AccountHolderName;
        private decimal BankBalance;

        public BankAccount(string name, decimal innitialBalance)
        {
            AccountHolderName = name;
            BankBalance = innitialBalance;
        }

        public void Credited(decimal amount)
        {
            if (amount > 0)
            {
                BankBalance += amount;
                Console.WriteLine($"Credited : {amount}");
            }
            else
            {
                Console.WriteLine($"Current balance {BankBalance}");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= BankBalance)
            {
                BankBalance -= amount;
                Console.WriteLine($"Withdraw : {amount}");
            }
            else
            {
                Console.WriteLine($"Current Balance {BankBalance}");
            }
        }
        public decimal GetCurrentBalance()
        {
            return BankBalance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var tran = new BankAccount("Swapnil", 2000);
            tran.Credited(500);
            tran.Withdraw(150);
            Console.WriteLine($"{tran.GetCurrentBalance()}");
        }
    }
}
