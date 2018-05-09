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
            actionpoints.Add(new Actionpoint(DateTime.Today, "specific string1", "measurable string1", "assignable string1", "string realistic1"));
            actionpoints.Add(new Actionpoint(DateTime.Today, "specific string2", "measurable string2", "assignable string2", "string realistic2"));
            actionpoints.Add(new Actionpoint(DateTime.Today, "specific string3", "measurable string3", "assignable string3", "string realistic3"));
            actionpoints.Add(new Actionpoint(DateTime.Today, "specific string4", "measurable string4", "assignable string4", "string realistic4"));

        }

        public List<Actionpoint> GetActionpoints()
        {
            return actionpoints;
        }

        public void AddActionpoint(Actionpoint actionpoint)
        {
            actionpoints.Add(actionpoint);
        }
    }
}
