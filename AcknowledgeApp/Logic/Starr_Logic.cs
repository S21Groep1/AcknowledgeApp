using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;


namespace Logic
{
    public class Starr_Logic
    {
        private IStarrContext context;

        public Starr_Logic(StorageType storageType)
        {
            switch (storageType)
            {
                //case StorageType.Database: context = new StarrDBContext(); break;
                case StorageType.Memory: context = new StarrMemoryContext(); break;
            }
        }

        public void Create(Starr starr) => context.Create(starr);
        public IEnumerable<Starr> GetAll() => context.GetAll();
        public Starr Get(int id) => context.Get(id);
        public void UpdateStarr(Starr sf) => context.UpdateStarr(sf);
    }
}
