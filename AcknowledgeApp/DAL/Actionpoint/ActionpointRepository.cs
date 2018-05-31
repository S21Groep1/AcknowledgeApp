using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    public class ActionpointRepository
    {
        private readonly IActionpointcontext context = new ActionpointContext();

        public List<Actionpoint> GetAllActionpoints()
        {
            return context.GetActionpoints();
        }

        public void AddActionpoint(Actionpoint actionpoint)
        {
            context.AddActionpoint(actionpoint);
        }
    }
}
