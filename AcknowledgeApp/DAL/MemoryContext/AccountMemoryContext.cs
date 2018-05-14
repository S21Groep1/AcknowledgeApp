using System;
using System.Collections.Generic;
using Models;

namespace DAL
{
    public class AccountMemoryContext : IAccountContext
    {
        private static List<Account> accounts = new List<Account>();

        public AccountMemoryContext()
        {
            accounts.Add(new Account() { Email = "admin@admin.com", Password = "AdminAdmin" });
        }

        public bool CreateAccount(Account acc)
        {
            bool accountExists = accounts.Exists(a => a.Email == acc.Email);
            if (!accountExists)
            {
                try
                {
                    accounts.Add(acc);
                    return true;
                } catch( Exception ex)
                {
                    throw new Exception("Something went wrong : " + ex.Message);
                }
            } else
            {
                throw new Exception("Account already went wrong");
            }
        }

        public bool Exists(Account acc) => accounts.Exists(a => a.Email == acc.Email && a.Password == acc.Password);

        public bool Login(Account acc)
        {
            bool accountExists = accounts.Exists(a => a.Email == acc.Email && a.Password == acc.Password);
            if (accountExists)
            {
                return true;
            }
            else
            {
                throw new Exception("Account doesn't exist!");
            }
        }
    }
}