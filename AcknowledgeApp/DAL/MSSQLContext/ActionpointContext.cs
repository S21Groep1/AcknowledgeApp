using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class ActionpointContext : IActionpointContext
    {
        private const string connString = @"Data Source=s2acknowledge.database.windows.net;Initial Catalog=Acknowledge;Integrated Security=False;User ID=coenfusing;Password=Wachtwoord2018!;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Actionpoint> GetActionpoints(int id)
        {
            List<Actionpoint> returnList = new List<Actionpoint>();
            
            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "GetAllActionPointsByStarr";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            returnList.Add(new Actionpoint()
                            {
                                Assignable = reader["Assignable"].ToString(),
                                LastEdit = Convert.ToDateTime(reader["EditDate"]),
                                Id = Convert.ToInt32(reader["Id"]),
                                Iscomplete = Convert.ToBoolean(reader["isComplete"]),
                                Measurable = reader["Measurable"].ToString(),
                                Realistic = reader["Realistic"].ToString(),
                                SoftSkill = reader["SoftSkill"].ToString(),
                                Specific = reader["Specific"].ToString(),
                                StartDate = Convert.ToDateTime(reader["StartDate"]),
                                TimeRelated = reader["TimeRelated"].ToString(),
                                UserId = Convert.ToInt32(reader["UserId"])
                            });
                        }
                    }
                }
            }
            return returnList;
        }
        public void CreateNewActionpoint(Actionpoint actionpoint)
        {
            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "CreateNewActionpoint";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("Assignable", actionpoint.Assignable);
                    cmd.Parameters.AddWithValue("LastEdit", actionpoint.LastEdit);
                    cmd.Parameters.AddWithValue("Iscomplete", actionpoint.Iscomplete);
                    cmd.Parameters.AddWithValue("Measurable", actionpoint.Measurable);
                    cmd.Parameters.AddWithValue("Realistic", actionpoint.Realistic);
                    cmd.Parameters.AddWithValue("SoftSkill", actionpoint.SoftSkill);
                    cmd.Parameters.AddWithValue("Specific", actionpoint.Specific);
                    cmd.Parameters.AddWithValue("StartDate", actionpoint.StartDate);
                    cmd.Parameters.AddWithValue("TimeRelated", actionpoint.TimeRelated);
                    cmd.Parameters.AddWithValue("UserId", actionpoint.UserId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        private int GetLastActionPointId()
        {
            int x = 0;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "GetLastActionPointId";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            x = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
            }

            return x;
        }
        public List<Actionpoint> GetAllActionpointsByUser(int userId)
        {
            List<Actionpoint> returnList = new List<Actionpoint>();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "GetAllActionPointsByUser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userId", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.HasRows)
                            {
                                returnList.Add(new Actionpoint()
                                {
                                    Assignable = reader["Assignable"].ToString(),
                                    LastEdit = Convert.ToDateTime(reader["LastEdit"]),
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Iscomplete = Convert.ToBoolean(reader["isComplete"]),
                                    Measurable = reader["Measurable"].ToString(),
                                    Realistic = reader["Realistic"].ToString(),
                                    SoftSkill = reader["SoftSkill"].ToString(),
                                    Specific = reader["Specific"].ToString(),
                                    StartDate = Convert.ToDateTime(reader["StartDate"]),
                                    TimeRelated = reader["TimeRelated"].ToString(),
                                    UserId = Convert.ToInt32(reader["UserId"])
                                });
                            }
                        }
                    }
                }
            }
            return returnList;
        }
        public void AddActionPointToStarr(int actionpointId, int starrId)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "AddActionPointToStarr";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("ActionpointId", actionpointId);
                    cmd.Parameters.AddWithValue("StarrId", starrId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}