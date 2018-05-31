using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Models;

namespace Logic
{
    public class Actionpoint_Logic
    {
        private ActionpointRepository actionrepo = new ActionpointRepository();

        public List<Actionpoint> GetAllActionpoints()
        {
            return actionrepo.GetAllActionpoints();
        }

        public void AddActionpoint(Actionpoint actionpoint)
        {
            actionrepo.AddActionpoint(actionpoint);
        }
        
    }
}
