using DAL;
using Models;
using System.Collections.Generic;

namespace Repository
{
    public class UserRepository
    {
        public IUserContext context;

        public UserRepository()
        {
            context = new UserContext();
        }

        public User GetAccountByEmail(string email) => context.GetUserByEmail(email);
        public bool Login(User acc) => context.Login(acc);
        public void AddAuthenticationCode(int userId, int AuthNumber) => context.AddAuthenticationCode(userId, AuthNumber);
        public int GetAuthCode(int userId) => context.GetAuthCode(userId);
        public void RemoveAuthCode(int userId) => context.RemoveAuthCode(userId);
        public List<string> GetAllCoachesNames() => context.GetAllCoachesNames();
        public int GetCoachIdByName(string coachName) => context.GetCoachIdByName(coachName);
    }
}