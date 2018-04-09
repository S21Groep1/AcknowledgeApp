using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace AcknowledgeApp.Models
{
    public class Viewmodel
    {
        Actionpoint actiepunt = new Actionpoint();

        public string SMART_specific
        {
            set { actiepunt.Specific = value; }
            get
            {
                return actiepunt.Specific;
            }
        }

        public string Actionpointdeadline
        {
            get
            {
                return actiepunt.StartDate();
            }
        }




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

        

    }
}
