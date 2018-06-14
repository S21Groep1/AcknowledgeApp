using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class UserContext : IUserContext
    {
        private const string connString = @"Data Source=s2acknowledge.database.windows.net;Initial Catalog=Acknowledge;Integrated Security=False;User ID=coenfusing;Password=Wachtwoord2018!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public UserContext()
        {

        }

        public User GetUserByEmail(string email)
        {
            User toReturn = new User();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "GetUserByEmail";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Email", email);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            toReturn = new User()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Email = reader["Email"].ToString(),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Niveau = Convert.ToInt32(reader["Niveau"]),
                                Password = reader["Password"].ToString(),
                                IsCoach = (bool)reader["IsCoach"],
                                Function = (eFunctions)Enum.ToObject(typeof(eFunctions), Convert.ToInt32(reader["Function"])),
                                Adress = reader["Adress"].ToString()
                            };
                        }
                    }
                }
            }
            return toReturn;
        }          
        public bool Login(User user)
        {
            string Email = user.Email;
            string Password = user.Password;

            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Login";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Email", Email);
                    cmd.Parameters.AddWithValue("Password", Password);

                    int? check = (int?)cmd.ExecuteScalar();

                    if(check == 1)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
        public void AddAuthenticationCode(int userId, int authCode)
        {
            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "AddAuthCode";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userId);
                    cmd.Parameters.AddWithValue("authCode", authCode);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public int GetAuthCode(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "GetAuthCode";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userId);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int toReturn = 0;
                        if (reader.Read())
                        {
                            toReturn = Convert.ToInt32(reader["AuthCode"]);
                        }
                        return toReturn;
                    }
                }
            }
        }
        public void RemoveAuthCode(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "RemoveAuthCode";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<string> GetAllCoachesNames()
        {
            List<string> returnList = new List<string>();

            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "GetAllCoachesNames";
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            returnList.Add(reader["FirstName"].ToString() + " " + reader["LastName"].ToString());
                        }
                    }
                }
            }
            return returnList;
        }
        public int GetCoachIdByName(string coachName)
        {
            string[] Name = coachName.Split(' ');
            string FirstName = Name[0];
            string LastName = Name[1];
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "GetCoachIdByName";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("FirstName", FirstName);
                    cmd.Parameters.AddWithValue("LastName", LastName);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
            }
            return id;
        }

    }
}