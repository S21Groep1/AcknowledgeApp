using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Account
    {
        private string email;
        private string password;
        private bool coach;

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public bool Coach { get => coach; set => coach = value; }

        public Account(string email)
        {
            this.Email = email;
        }
    }
}
