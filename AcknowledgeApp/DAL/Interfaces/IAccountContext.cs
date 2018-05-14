using Models;

namespace DAL
{
    public interface IAccountContext
    {
        bool CreateAccount(Account acc);
        bool Login(Account acc);
        bool Exists(Account acc);
    }
}