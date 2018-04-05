using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class User
    {
        private string firstname;
        private string lastname;
        private Functions function;
        private int level;
        private List<string> hardskilllist;

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Niveau { get => level; set => level = value; }
        public List<string> Hardskilllist { get => hardskilllist; set => hardskilllist = value; }
        public Functions Function { get => function; set => function = value; }

        public enum Functions
        {
            Employee,
            Trainee
        }
    }
}
