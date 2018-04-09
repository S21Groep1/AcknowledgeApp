using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    class ActionpointContext : IActionpointcontext
    {
        private static List<Actionpoint> actionpoints = new List<Actionpoint>();

        public ActionpointContext()
        {

        }

        public List<Actionpoint> GetActionpoints()
        {
            return actionpoints;
        }
    }
}
