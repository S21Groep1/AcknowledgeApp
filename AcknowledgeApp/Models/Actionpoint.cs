using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Actionpoint
    {
        
        private DateTime startDate = DateTime.Now;
        private bool iscomplete;
        private string specific;
        private string measurable;
        private string assignable;
        private string realistic;
        private DateTime deadline;

        
        
        public bool Iscomplete { get => iscomplete; set => iscomplete = value; }
        public string Specific { get => specific; set => specific = value; }
        public string Measurable { get => measurable; set => measurable = value; }
        public string Assignable { get => assignable; set => assignable = value; }
        public string Realistic { get => realistic; set => realistic = value; }

        //date mm/dd/yy
        string[] dateformats = { "d" };
        string datetime;
        
        public string StartDate()
        {
            foreach(string datefrmts in dateformats)
            {
                datetime = string.Format("{0}\n", startDate.ToString(datefrmts));
            }
            return datetime;
        }



        public override string ToString()
        {
            return Specific + ", " + Measurable + ", " + Assignable + ", " + Realistic + ", " + StartDate();
        }

    }
}
