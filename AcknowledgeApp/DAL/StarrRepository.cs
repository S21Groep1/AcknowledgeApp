using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    public class StarrRepository
    {
        private readonly IStarrContext context = new StarrContext();

        public List<Starr> GetAllStarrs()
        {
            return context.GetAllStarrs();
        }

        public Starr GetStarrById(int id)
        {
            return context.GetStarrById(id);
        }

        public void UpdateStarr(Starr sf)
        {
            context.UpdateStarr(sf);
        }
    }
}
