using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class BankAccountCommand : ICommand
    {
        private BankAccount account;
        private Action action;
        private int amount;
        private bool succeded;

        public BankAccountCommand(BankAccount account, Action action, int amount)
        {
            this.account = account;
            this.action = action;
            this.amount = amount;
        }

        public void Call()
        {
            switch (action)
            {
                case Action.Deposit:
                    account.Deposit(amount);
                    succeded = true;
                    break;

                case Action.Withdraw:
                    succeded = account.Withdraw(amount);
                    break;

                default:
                    break;
            }
        }

        public void Undo()
        {
            if (!succeded)
            {
                return;
            }

            switch (action)
            {
                case Action.Deposit:
                    account.Withdraw(amount);
                    break;

                case Action.Withdraw:
                    account.Deposit(amount);
                    break;

                default:
                    break;
            }
        }

        public enum Action
        {
            Deposit,
            Withdraw
        }
    }
}