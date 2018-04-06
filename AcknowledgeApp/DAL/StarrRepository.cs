using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    public class StarrRepository
    {
        private readonly IStarrContext context = new StarrContext();

        public List<Starrform> GetAllStarrs()
        {
            return context.GetAllStarrs();
        }

        public Starrform GetStarrById(int id)
        {
            return context.GetStarrById(id);
        }

        public void UpdateStarr(Starrform sf)
        {
            context.UpdateStarr(sf);
        }
    }
}
