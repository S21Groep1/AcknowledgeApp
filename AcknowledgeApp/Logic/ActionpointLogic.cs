using System.Collections.Generic;
using Repository;
using Models;

namespace Logic
{
    public class ActionpointLogic
    {
        private ActionpointRepository repo = new ActionpointRepository();

        public List<Actionpoint> GetAllActionpointsByUser(int userId) => repo.GetAllActionpointsByUser(userId);
        public List<Actionpoint> GetAllActionpoints(int starrId) => repo.GetAllActionpoints(starrId);
        public void AddActionpoint(Actionpoint actionpoint) => repo.CreateNewActionpoint(actionpoint);
        public void AddActionPointToStarr(int actionpointId, int starrId) => repo.AddActionPointToStarr(actionpointId, starrId);
    }
}