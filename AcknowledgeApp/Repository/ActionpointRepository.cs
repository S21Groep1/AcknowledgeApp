using System.Collections.Generic;
using Models;
using DAL;

namespace Repository
{
    public class ActionpointRepository
    {
        private readonly IActionpointContext context;

        public ActionpointRepository()
        {
            context = new ActionpointContext();
        }

        public List<Actionpoint> GetAllActionpointsByUser(int userId) => context.GetAllActionpointsByUser(userId);
        public List<Actionpoint> GetAllActionpoints(int starrId) => context.GetActionpoints(starrId);
        public void CreateNewActionpoint(Actionpoint actionpoint) => context.CreateNewActionpoint(actionpoint);
        public void AddActionPointToStarr(int actionpointId, int starrId) => context.AddActionPointToStarr(actionpointId, starrId);
    }
}