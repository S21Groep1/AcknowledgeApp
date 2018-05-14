using System.Collections.Generic;
using Models;
using Repository;

namespace Logic
{
    public class StarrLogic
    {
        private StarrRepository repo;

        public StarrLogic(LogicTypes type)
        {
            switch (type)
            {
                case LogicTypes.ActualLogic: repo = new StarrRepository(DAL.ContextTypes.MSSQLContext); break;
                case LogicTypes.TestLogic: repo = new StarrRepository(DAL.ContextTypes.MemoryContext); break;
            }
        }

        public List<Starr> GetAllStarrs()
        {
            return repo.GetAllStarrs();
        }

        public Starr GetStarrById(int id)
        {
            return repo.GetStarrById(id);
        }

        public void UpdateStarr(Starr sf)
        {
            repo.UpdateStarr(sf);
        }
    }
}