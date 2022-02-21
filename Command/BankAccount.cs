using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class BankAccount
    {
        private int balance;
        private int overdraftLimit = -500;

        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited: ${amount} - Balance is now: {balance}");
        }

        public bool Withdraw(int amount)
        {
            if (balance - amount >= overdraftLimit)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew ${amount} - Balance is now: {balance}");
                return false;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}";
        }
    }
}