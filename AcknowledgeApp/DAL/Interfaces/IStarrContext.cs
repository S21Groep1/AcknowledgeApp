using System.Collections.Generic;
using Models;

namespace DAL
{
    public interface IStarrContext
    {
        IEnumerable<Starr> GetAllStarrs();
        Starr GetStarrById(int id);
        void UpdateStarr(Starr sf);
    }
}