using Models;
using Repository;
using System;
using System.Collections.Generic;

namespace Logic
{
    public class UserLogic
    {
        UserRepository repo;

        public UserLogic()
        {
            repo = new UserRepository();
        }

        public User GetAccountByEmail(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                throw new Exception("No username provided");
            }

            return repo.GetAccountByEmail(email);
        }
        public void Login(User user)
        {
            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
            {
                throw new Exception("Please enter a username or password.");
            }

            if (!repo.Login(user))
            {
                throw new Exception("Login failed.");
            }
            else
            {
                int newAuthCode = CreateAuthCode();
                int userId = repo.GetAccountByEmail(user.Email).Id;
                repo.AddAuthenticationCode(userId, newAuthCode);
                Mailer mailer = new Mailer();
                mailer.SendMail(user.Email, newAuthCode);
            }
        }
        public void PerformAuthentication(Authentication auth, int userId)
        {
            if (string.IsNullOrEmpty(auth.AuthenticationCode.ToString())){
                throw new Exception("Please enter a code");
            }

            if(auth.AuthenticationCode != repo.GetAuthCode(userId)) {
                throw new Exception("Incorrect auth code");
            }

            repo.RemoveAuthCode(userId);
        }
        private int CreateAuthCode()
        {
            Random rand = new Random();
            int authnum = rand.Next(100000, 1000000);

            return authnum;
        }
        public List<string> GetAllCoachesNames() => repo.GetAllCoachesNames();
        public int GetCoachIdByName(string coachName) => repo.GetCoachIdByName(coachName);
    }
}