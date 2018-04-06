using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    interface IStarrContext
    {
        List<Starrform> GetAllStarrs();
        Starrform GetStarrById(int id);
        void UpdateStarr(Starrform sf);
    }
}
