using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    public interface IStarrContext
    {
        void Create(Starr sf);
        IEnumerable<Starr> GetAll();
        Starr Get(int id);
        void UpdateStarr(Starr sf);
    }
}
