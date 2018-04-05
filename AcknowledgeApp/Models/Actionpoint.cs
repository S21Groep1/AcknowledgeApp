using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Actionpoint
    {
        
        private DateTime startDate;
        private DateTime deadline;
        private bool iscomplete;
        private string smart;


        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public bool Iscomplete { get => iscomplete; set => iscomplete = value; }
        public string SMART { get => smart; set => smart = value; }

        public List<string> Softskilllist()
        {
            List<string> softskills = new List<string>();
            //string propably needs to be replaced with the class softskills, this makes the rows below unnecessary
            softskills.Add("Communicatie");
            softskills.Add("Conflicthantering");
            softskills.Add("Interviewen");
            softskills.Add("Onderzoek");
            softskills.Add("Presenteren");
            softskills.Add("Project");
            softskills.Add("Rapporteren");
            softskills.Add("Reflecteren");
            softskills.Add("Samenwerken");
            softskills.Add("Schrijfvaardigheden");
            softskills.Add("Documenteren");
            softskills.Add("Omgang met feedback");
            softskills.Add("Initiatief nemen");
            softskills.Add("Plannen");
            return softskills;
        }

        public override string ToString()
        {
            return Actionpointname;
        }

    }
}
