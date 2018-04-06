using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace AcknowledgeApp.Models
{
    public class StarrListViewModel
    {
        public IEnumerable <Starrform> Starrs { get; set; }

        public StarrListViewModel(IEnumerable<Starrform> starrs)
        {
            this.Starrs = starrs;
        }

    }
}
