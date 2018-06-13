using System;
using System.Collections.Generic;
using Models;

namespace DAL
{
    public class ActionPointMemoryContext : IActionpointContext
    {
        private static List<Actionpoint> actionpoints = new List<Actionpoint>();

        public ActionPointMemoryContext()
        {

        }

        public void AddActionPointToStarr(int actionpointId, int starrId)
        {
            throw new NotImplementedException();
        }

        public void CreateNewActionpoint(Actionpoint actionpoint)
        {
            throw new NotImplementedException();
        }

        public List<Actionpoint> GetActionpoints(int id)
        {
            throw new NotImplementedException();
        }

        public List<Actionpoint> GetAllActionpointsByUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}