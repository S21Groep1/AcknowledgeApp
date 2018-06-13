using Models;
using System.Collections.Generic;

namespace DAL
{
    public interface IUserContext
    {
        User GetUserByEmail(string email);
        bool Login(User acc);
        void AddAuthenticationCode(int userId, int AuthNumber);
        int GetAuthCode(int userId);
        void RemoveAuthCode(int userId);
        List<string> GetAllCoachesNames();
        int GetCoachIdByName(string coachName);
    }
}