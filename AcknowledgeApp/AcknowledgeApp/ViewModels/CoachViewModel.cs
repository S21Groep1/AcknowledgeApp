using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace AcknowledgeApp.ViewModels
{
    public class CoachViewModel
    {
        public User Coach { get; set; }
        public IEnumerable<Starr> Starrs { get; set; }

        public CoachViewModel(IEnumerable<Starr> starrs)
        {
            this.Starrs = starrs;
        }
    }
}
