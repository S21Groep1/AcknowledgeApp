using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Actionpoint
    {
        
        private DateTime startDate;
        private bool iscomplete;
        private string specific;
        private string measurable;
        private string assignable;
        private string realistic;
        private string time_related;
        private DateTime deadline;

        
        
        public bool Iscomplete { get => iscomplete; set => iscomplete = value; }
        public string Specific { get => specific; set => specific = value; }
        public string Measurable { get => measurable; set => measurable = value; }
        public string Assignable { get => assignable; set => assignable = value; }
        public string Realistic { get => realistic; set => realistic = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public string Time_related { get => time_related; set => time_related = value; }

        //date mm/dd/yy
        string[] dateformats = { "d" };
        string deadlinedatetime;
        
        public string DeadlineActionpoint()
        {
            foreach(string datefrmts in dateformats)
            {
                deadlinedatetime = string.Format("{0}\n", Deadline.ToString(datefrmts));
            }
            return deadlinedatetime;
        }
        
        public Actionpoint()
        {

        }

        public Actionpoint(DateTime deadline, string specific, string measurable, string assingnable, string realistic, string time_related)
        {
            this.StartDate = DateTime.Now;
            this.Deadline = deadline;
            this.Specific = specific;
            this.Measurable = measurable;
            this.Assignable = assingnable;
            this.Realistic = realistic;
            this.Time_related = time_related;
            
            
        }

        public override string ToString()
        {
            return Specific + ", " + Measurable + ", " + Assignable + ", " + Realistic + ", " + DeadlineActionpoint();
        }

    }
}
