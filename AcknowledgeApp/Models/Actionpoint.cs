using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Actionpoint
    {
        private string actionpointname;

        public string Actionpointname { get => actionpointname; set => actionpointname = value; }

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
