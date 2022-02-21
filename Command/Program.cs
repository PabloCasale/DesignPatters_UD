using System;
using System.Collections.Generic;
using System.Linq;

namespace Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Command Pattern");

            var bankAccount = new BankAccount();
            var commands = new List<BankAccountCommand>()
            {
                new BankAccountCommand(bankAccount, BankAccountCommand.Action.Deposit, 100),
                new BankAccountCommand(bankAccount, BankAccountCommand.Action.Withdraw, 100)
            };
            Console.WriteLine(bankAccount);

            foreach (var item in commands)
            {
                item.Call();
            }
            Console.WriteLine(bankAccount);

            foreach (var item in Enumerable.Reverse(commands))
            {
                item.Undo();
            }
            Console.WriteLine(bankAccount);
        }
    }
}