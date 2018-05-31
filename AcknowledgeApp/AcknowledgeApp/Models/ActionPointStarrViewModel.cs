using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace AcknowledgeApp.Models
{
    public class ActionPointStarrViewModel
    {
        public List<Actionpoint> Points { get; set; }
        public Starr CurrentStarr { get; set; }

        public ActionPointStarrViewModel(List<Actionpoint> points, Starr cs)
        {
            this.Points = points;
            this.CurrentStarr = cs;
        }
    }
}
