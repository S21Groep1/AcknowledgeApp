using System;

namespace Models
{
    public class Actionpoint
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Specific { get; set; }
        public string Measurable { get; set; }
        public string Assignable { get; set; }
        public string Realistic { get; set; }
        public string TimeRelated { get; set; }
        public string SoftSkill { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastEdit { get; set; }
        public bool Iscomplete { get; set; }

        public Actionpoint( int Id, int UserId, string Specific, string Measurable, string Assignable, string Realistic, string TimeRelated, string SoftSkill, DateTime StartDate, DateTime LastEdit, bool Iscomplete)
        {
            this.Id = Id;
            this.UserId = UserId;
            this.Specific = Specific;
            this.Measurable = Measurable;
            this.Assignable = Assignable;
            this.Realistic = Realistic;
            this.TimeRelated = TimeRelated;
            this.SoftSkill = SoftSkill;
            this.StartDate = StartDate;
            this.LastEdit = LastEdit;
            this.Iscomplete = Iscomplete;
        }
       
        public Actionpoint()
        {

        }

        public override string ToString()
        {
            return Specific + ", " + Measurable + ", " + Assignable + ", " + Realistic + ", " + TimeRelated;
        }
    }
}