using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    interface IStarrContext
    {
        List<Starr> GetAllStarrs();
        Starr GetStarrById(int id);
        void UpdateStarr(Starr sf);
    }
}
