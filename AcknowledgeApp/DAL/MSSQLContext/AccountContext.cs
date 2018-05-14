using System;
using Models;

namespace DAL
{
    public class AccountContext : IAccountContext
    {
        public bool CreateAccount(Account acc)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Account acc)
        {
            throw new NotImplementedException();
        }

        public bool Login(Account acc)
        {
            throw new NotImplementedException();
        }
    }
}