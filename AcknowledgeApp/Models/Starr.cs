using System;
using System.Collections.Generic;

namespace Models
{
    public class Starr 
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CoachId { get; set; }
        public string Situation { get; set; }
        public string Task { get; set; }
        public string Action { get; set; }
        public string Result { get; set; }
        public string Reflection { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastEdit { get; set; }
        public eEmo Feeling { get; set; }
        public List<Actionpoint> Actionpoints = new List<Actionpoint>();

        public Starr(int Id, int UserId, int CoachId, string Situation, string Task, string Action, string Result, string Reflection, string Name, DateTime StartDate, DateTime LastEdit, eEmo Feeling, List<Actionpoint> Actionpoints )
        {
            this.Id = Id;
            this.UserId = UserId;
            this.CoachId = CoachId;
            this.Situation = Situation;
            this.Task = Task;
            this.Action = Action;
            this.Result = Result;
            this.Reflection = Reflection;
            this.Name = Name;
            this.StartDate = StartDate;
            this.LastEdit = LastEdit;
            this.Feeling = Feeling;
            this.Actionpoints = Actionpoints;
        }

        public Starr()
        {

        }

        public void CopyFrom(Starr other)
        {
            this.Id = other.Id;
            this.UserId = other.UserId;
            this.CoachId = other.CoachId;
            this.Situation = other.Situation;
            this.Task = other.Task;
            this.Action = other.Action;
            this.Result = other.Result;
            this.Reflection = other.Reflection;
            this.Name = other.Name;
            this.StartDate = other.StartDate;
            this.LastEdit = other.LastEdit;
            this.Feeling = other.Feeling;
            this.Actionpoints = other.Actionpoints;           
        }
    }
}