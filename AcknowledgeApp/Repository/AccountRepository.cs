using Models;
using DAL;

namespace Repository
{
    public class AccountRepository
    {
        private IAccountContext context;

        public AccountRepository(ContextTypes type)
        {
            switch (type)
            {
                case ContextTypes.MemoryContext: context = new AccountMemoryContext(); break;
                case ContextTypes.MSSQLContext: context = new AccountContext(); break;
            }
        }

        public bool CreateAccount(Account acc) => context.CreateAccount(acc);

        public bool Login(Account acc) => context.Login(acc);

        public bool DoesExist(Account acc) => context.Exists(acc);
    }
}