using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class Account
    {
        private string email;
        private string password;

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}
