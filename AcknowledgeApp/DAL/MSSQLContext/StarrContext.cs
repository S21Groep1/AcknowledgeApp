using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class StarrContext : IStarrContext
    {
        private const string connString = @"Data Source=s2acknowledge.database.windows.net;Initial Catalog=Acknowledge;Integrated Security=False;User ID=coenfusing;Password=Wachtwoord2018!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public StarrContext()
        {

        }

        public List<Starr> GetAllStarrsForCoach(int coachId)
        {
            List<Starr> returnList = new List<Starr>();
            int currentStarrId = 0;

            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "GetAllStarrsForCoach";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("coachId", coachId);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            currentStarrId = Convert.ToInt32(reader["Id"]);
                            returnList.Add(new Starr()
                            {
                                CoachId = Convert.ToInt32(reader["CoachId"]),
                                Feeling = (eEmo)Enum.ToObject(typeof(eEmo), Convert.ToInt32(reader["Feeling"])),
                                Id = Convert.ToInt32(reader["Id"]),
                                LastEdit = Convert.ToDateTime(reader["LastEdit"]),
                                Name = reader["Name"].ToString(),
                                Reflection = reader["Reflection"].ToString(),
                                Result = reader["Result"].ToString(),
                                Situation = reader["Situation"].ToString(),
                                StartDate = Convert.ToDateTime(reader["StartDate"]),
                                Task = reader["Task"].ToString(),
                                UserId = Convert.ToInt32(reader["UserId"]),
                                Actionpoints = GetStarrActionPoints(currentStarrId),
                                Action = reader["Action"].ToString()
                            });
                        }
                    }
                }
            }

            return returnList;
        }
        public List<Starr> GetAllStarrsForUser(int userId)
        {
            List<Starr> returnList = new List<Starr>();
            int currentStarrId;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "GetAllStarrsForUser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("UserId", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            currentStarrId = Convert.ToInt32(reader["Id"]);
                            returnList.Add(new Starr()
                            {
                                CoachId = Convert.ToInt32(reader["CoachId"]),
                                Feeling = (eEmo)Enum.ToObject(typeof(eEmo), Convert.ToInt32(reader["Feeling"])),
                                Id = Convert.ToInt32(reader["Id"]),
                                LastEdit = Convert.ToDateTime(reader["LastEdit"]),
                                Name = reader["Name"].ToString(),
                                Reflection = reader["Reflection"].ToString(),
                                Result = reader["Result"].ToString(),
                                Situation = reader["Situation"].ToString(),
                                StartDate = Convert.ToDateTime(reader["StartDate"]),
                                Task = reader["Task"].ToString(),
                                UserId = Convert.ToInt32(reader["UserId"]),
                                Actionpoints = GetStarrActionPoints(currentStarrId),
                                Action = reader["Action"].ToString()
                            });
                        }
                    }
                }
            }
            return returnList;
        }
        public Starr GetStarrById(int id)
        {
            Starr returnStarr = new Starr();
            int currentStarrId = 0;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "GetStarrById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("starrId", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            currentStarrId = Convert.ToInt32(reader["Id"]);

                            returnStarr.CoachId = Convert.ToInt32(reader["CoachId"]);
                            returnStarr.Feeling = (eEmo)Enum.ToObject(typeof(eEmo), Convert.ToInt32(reader["Feeling"]));
                            returnStarr.Id = Convert.ToInt32(reader["Id"]);
                            returnStarr.LastEdit = Convert.ToDateTime(reader["LastEdit"]);
                            returnStarr.Name = reader["Name"].ToString();
                            returnStarr.Reflection = reader["Reflection"].ToString();
                            returnStarr.Result = reader["Result"].ToString();
                            returnStarr.Situation = reader["Situation"].ToString();
                            returnStarr.StartDate = Convert.ToDateTime(reader["StartDate"]);
                            returnStarr.Task = reader["Task"].ToString();
                            returnStarr.UserId = Convert.ToInt32(reader["UserId"]);
                            returnStarr.Actionpoints = GetStarrActionPoints(currentStarrId);
                            returnStarr.Action = reader["Action"].ToString();
                        }
                    }
                }
            }
            return returnStarr;
        }
        private List<Actionpoint> GetStarrActionPoints(int starrId)
        {
            List<Actionpoint> returnList = new List<Actionpoint>();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "GetAllActionPointsByStarr";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("starrId", starrId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            returnList.Add(new Actionpoint()
                            {
                                Assignable = reader["Assignable"].ToString(),
                                LastEdit = Convert.ToDateTime(reader["LastEdit"]),
                                Id = Convert.ToInt32(reader["Id"]),
                                Iscomplete = Convert.ToBoolean(reader["IsComplete"]),
                                Measurable = reader["Measurable"].ToString(),
                                Realistic = reader["Realistic"].ToString(),
                                SoftSkill = reader["SoftSkill"].ToString(),
                                Specific = reader["Specific"].ToString(),
                                StartDate = Convert.ToDateTime(reader["StartDate"]),
                                TimeRelated = reader["TimeRelated"].ToString(),
                                UserId = Convert.ToInt32(reader["UserId"]),
                            });
                        }
                    }
                }
            }
            return returnList;
        }
        public void AddStarr(Starr starr)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "CreateNewStarr";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("CoachId", starr.CoachId);
                    cmd.Parameters.AddWithValue("Feeling", starr.Feeling);
                    cmd.Parameters.AddWithValue("LastEdit", starr.LastEdit);
                    cmd.Parameters.AddWithValue("Name", starr.Name);
                    cmd.Parameters.AddWithValue("Reflection", starr.Reflection);
                    cmd.Parameters.AddWithValue("Situation", starr.Situation);
                    cmd.Parameters.AddWithValue("StartDate", starr.StartDate);
                    cmd.Parameters.AddWithValue("Task", starr.Task);
                    cmd.Parameters.AddWithValue("UserId", starr.UserId);
                    cmd.Parameters.AddWithValue("Result", starr.Result);
                    cmd.Parameters.AddWithValue("Action", starr.Action);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateStarr(Starr starr)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UpdateStarr";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("CoachId", starr.CoachId);
                    cmd.Parameters.AddWithValue("Feeling", starr.Feeling);
                    cmd.Parameters.AddWithValue("Id", starr.Id);
                    cmd.Parameters.AddWithValue("LastEdit", starr.LastEdit);
                    cmd.Parameters.AddWithValue("Name", starr.Name);
                    cmd.Parameters.AddWithValue("Reflection", starr.Reflection);
                    cmd.Parameters.AddWithValue("Situation", starr.Situation);
                    cmd.Parameters.AddWithValue("StartDate", starr.StartDate);
                    cmd.Parameters.AddWithValue("Task", starr.Task);
                    cmd.Parameters.AddWithValue("UserId", starr.UserId);               
                    cmd.Parameters.AddWithValue("Action", starr.Action);
                    cmd.Parameters.AddWithValue("Result", starr.Result);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<string> GetAllSoftSkills()
        {
            List<string> returnList = new List<string>();
            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "GetAllSoftSkills";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            returnList.Add(reader["SkillName"].ToString());
                        }
                    }
                }
            }
            return returnList;
        }
    }
}