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

        public void addStarr(Starr s)
        {
            repo.addStarr(s);
        }

    }
}
