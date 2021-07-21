using System;
using System.Collections.Generic;
using System.Text;
using AtvExceptions.Entities.Exceptions;

namespace AtvExceptions.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Withdraw(double amount)
        {
            if(Balance < 0.0 || Balance > WithdrawLimit)
            {
                throw new DomainExeptions(" The amount exceeds withdraw limit ");
            }

            if(amount > Balance)
            {
                throw new DomainExeptions(" Not enough balance");
            }
            
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }


    }
}
