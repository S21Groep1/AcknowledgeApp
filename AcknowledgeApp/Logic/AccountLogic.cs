using Models;
using Repository;
using System;

namespace Logic
{
    public class AccountLogic
    {
        AccountRepository repo;

        public AccountLogic(LogicTypes type)
        {
            switch (type)
            {
                case LogicTypes.ActualLogic: repo = new AccountRepository(DAL.ContextTypes.MSSQLContext); break;
                case LogicTypes.TestLogic: repo = new AccountRepository(DAL.ContextTypes.MemoryContext); break;
            }
        }

        public bool RegisterNewAccount(Account acc) => repo.CreateAccount(acc);

        public bool Login(Account acc)
        {
            // Checks if input is null or empty
            if (string.IsNullOrEmpty(acc.Email)){
                throw new Exception("Please enter a email adress");
            }
            if (string.IsNullOrEmpty(acc.Password))
            {
                throw new Exception("Please enter a password");
            }

            return repo.Login(acc);
        }
    }
}