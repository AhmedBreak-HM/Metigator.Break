using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Account
    {
        private decimal _balance;

        public decimal Balance { get { return _balance; } set { _balance = value; } }
        public Account() { 
            Balance = 0;
        }
        public Account( decimal balance)
        {
            _balance = balance;
        }

        ~Account() { }

        public event EventHandler? OnOverDraft;


        public void Withdraw(decimal amount)
        {
            if (amount > _balance)
                this.OnOverDraft(this, null);
            else
                _balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public static Account operator +(Account a, Account b)
        {
            return new Account { Balance = a.Balance + b.Balance };
        }

    }
}
