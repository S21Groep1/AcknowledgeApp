using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    class SQLContext
    {
        private const string connecstring = @"Data Source=s2acknowledge.database.windows.net;Initial Catalog=Acknowledge;Integrated Security=False;User ID=coenfusing;Password=Wachtwoord2018!;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Actionpoint> GetActionpoints(int id)
        {
            List<Actionpoint> actionpoints = new List<Actionpoint>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connecstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "dbo.GetActionPointData";
                        cmd.Parameters.AddWithValue("in_UserId", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    actionpoints.Add(new Actionpoint(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                                }
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch
            {
                throw new Exception();
            }

            return actionpoints;
        }

        public List<Account> GetCoaches()
        {
            List<Account> coaches = new List<Account>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connecstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "dbo.GetCoaches";
                        //cmd.Parameters.AddWithValue("in_UserId", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    coaches.Add(new Account(reader.GetString(0)));
                                }
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch
            {
                throw new Exception();
            }

            return coaches;
        }

        public void SaveActionpoint(Actionpoint actionpoint)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connecstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "dbo.SaveActionPointData";
                        cmd.Parameters.AddWithValue("in_Specific", actionpoint.Specific);
                        cmd.Parameters.AddWithValue("in_Measurable", actionpoint.Measurable);
                        cmd.Parameters.AddWithValue("in_Assignable", actionpoint.Assignable);
                        cmd.Parameters.AddWithValue("in_Realistic", actionpoint.Realistic);
                        cmd.Parameters.AddWithValue("in_Time_related", actionpoint.Time_related);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        public List<Starr> GetSTARR(int id)
        {
            List<Starr> starrs = new List<Starr>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connecstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "dbo.GetActionPointData";
                        cmd.Parameters.AddWithValue("in_UserId", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    starrs.Add(new Starr(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), (eEmotion)Enum.Parse(typeof(eEmotion), reader.GetString(8)), reader.GetString(9)));
                                }
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch
            {
                throw new Exception();
            }

            return starrs;
        }
    }
}
