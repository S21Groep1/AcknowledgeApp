using System.Collections.Generic;
using Models;

namespace DAL
{
    public interface IActionpointContext
    {
        List<Actionpoint> GetAllActionpointsByUser(int userId);
        List<Actionpoint> GetActionpoints(int id);
        void CreateNewActionpoint(Actionpoint actionpoint);
        void AddActionPointToStarr(int actionpointId, int starrId);
    }
}