﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4._ISP
{
    class Bank
    {
        List<BankAccount> accounts = new List<BankAccount>();

        public Bank()
        {
            accounts.Add(new BankAccount("Peter Test", "SomeStreet 1", "12345"));
        }

        public void ChangeAccountName(string accountNumber, string newName)
        {
            accounts.FirstOrDefault(account => account.AccountNumber == accountNumber).ChangeName(newName);
        }

        public void ChangeAddress(string accountNumber, string newAddress)
        {
            accounts.FirstOrDefault(account => account.AccountNumber == accountNumber).ChangeName(newAddress);
        }

        public void SendMoneyToAccount(string accountNumber, double amount)
        {
            accounts.FirstOrDefault(account => account.AccountNumber == accountNumber).ReceiveMoneyFromAccount(amount);
        }
    }
}
