using System.Collections.Generic;
using System.Linq;
using DAL;
using Models;

namespace Repository
{
    public class StarrRepository
    {
        private IStarrContext context;

        public StarrRepository(ContextTypes type)
        {
            switch (type)
            {
                case ContextTypes.MemoryContext: context = new StarrMemoryContext(); break;
                case ContextTypes.MSSQLContext: context = new StarrContext(); break;
            }
        }

        public List<Starr> GetAllStarrs() => context.GetAllStarrs().ToList();

        public Starr GetStarrById(int id) => context.GetStarrById(id);

        public void UpdateStarr(Starr sf) => context.UpdateStarr(sf);
    }
}