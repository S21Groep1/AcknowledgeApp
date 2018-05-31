using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    public class StarrRepository
    {
        private readonly IStarrContext context = new StarrMemoryContext();

        public IEnumerable<Starr> GetAll() => context.GetAll();

        public void UpdateStarr(Starr sf)
        {
            context.UpdateStarr(sf);
        }

        public void addStarr(Starr s)
        {
            context.addStarr(s);
        }
    }
}
