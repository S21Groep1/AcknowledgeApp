using System;

namespace Models
{
    public enum Emotions
    {
        Positive,
        Neutral,
        Negative
    }

    public class Starr 
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastEdit { get; set; }
        public String Situation { get; set; }
        public String Task { get; set; }
        public String Action { get; set; }
        public String Result { get; set; }
        public String Reflection { get; set; }
        public Emotions Feeling { get; set; }
        public String Coach { get; set; }

        public Starr(int id,String name, DateTime lastedit, string sit, string task, string act, string res, string refl, Emotions feel,String coach)
        {
            this.Id = id;
            this.Name = name;
            this.StartDate = DateTime.Now;
            this.LastEdit = lastedit;
            this.Situation = sit;
            this.Task = task;
            this.Action = act;
            this.Result = res;
            this.Reflection = refl;
            this.Feeling = feel;
            this.Coach = coach;
        }

        public Starr()
        {


        }

        public void CopyFrom(Starr other)
        {
            Id = other.Id;
            Name = other.Name;
            LastEdit = DateTime.Now;
            Situation = other.Situation;
            Task = other.Task;
            Action = other.Task;
            Result = other.Result;
            Reflection = other.Reflection;
            Coach = other.Coach;
        }

    }
}