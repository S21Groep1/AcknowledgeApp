using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Starrform
    {
        public DateTime StartDate { get; set; }
        public DateTime LastEdit { get; set; }
        public String Situation { get; set; }
        public String Task { get; set; }
        public String Action { get; set; }
        public String Result { get; set; }
        public String Reflection { get; set; }
        public Emotion Feeling { get; set; }

        public Starrform(DateTime lastedit, string sit, string task, string act, string res, string refl, Emotion feel)
        {
            this.StartDate = DateTime.Now;
            this.LastEdit = lastedit;
            this.Situation = sit;
            this.Task = task;
            this.Action = act;
            this.Result = res;
            this.Reflection = refl;
            this.Feeling = feel;
        }
    }
}
