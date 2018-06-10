using System.Collections.Generic;
using Models;

namespace AcknowledgeApp.ViewModels
{
    public class ActionPointStarrViewModel
    {
        public List<string> Coaches { get; set; }
        public List<string> SoftSkills { get; set; }
        public Actionpoint actionpoint { get; set; }
        public Starr starr { get; set; }
        public List<Starr> starrList { get; set; }
        public List<Actionpoint> starrActionPoints { get; set; }
        public List<Actionpoint> allActionPointsOfUser { get; set; }


        // Only for posting a new ActionPoint
        public string coachName { get; set; }

        public ActionPointStarrViewModel()
        {

        }

        public ActionPointStarrViewModel(List<string> Coaches, List<string> SoftSkills, Actionpoint actionpoint, Starr starr, 
            List<Actionpoint> actionpointList, List<Actionpoint> allActionPointsOfUser, List<Starr> starrList)
        {
            this.Coaches = Coaches;
            this.SoftSkills = SoftSkills;
            this.actionpoint = actionpoint;
            this.starr = starr;
            this.starrActionPoints = actionpointList;
            this.allActionPointsOfUser = allActionPointsOfUser;
            this.starrList = starrList;
        }
    }
}