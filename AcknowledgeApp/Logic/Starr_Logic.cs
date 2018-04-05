using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Logic
{
    class Starr_Logic : IStarr_Logic
    {
        public void makeStarr(DateTime edit, string situation, string task, string action, string result, string reflection, Emotion feel)
        {
            Starrform sf = new Starrform(edit,situation,task,action,result,reflection,feel);
        }
    }
}
