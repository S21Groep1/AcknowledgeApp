using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;


namespace Logic
{
    public class Starr_Logic
    {
        private StarrRepository repo = new StarrRepository();

        public List<Starrform> GetAllStarrs()
        {
            return repo.GetAllStarrs();
        }
        public Starrform GetStarrById(int id)
        {
            return repo.GetStarrById(id);
        }
        public void UpdateStarr(Starrform sf)
        {
            repo.UpdateStarr(sf);
        }

    }
}
