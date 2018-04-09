using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    class StarrContext : IStarrContext
    {
        private static List<Starr> starrs = new List<Starr>();

        public StarrContext()
        {
            if (starrs.Count == 0)
            {
                var x = Emotions.Positive;
                var x2 = Emotions.Negative;
                var x3 = Emotions.VeryPositive;
                var x4 = Emotions.VeryNegative;

                int starrId = 1;

                starrs.Add(new Starr(starrId++, "Teamwork", DateTime.Now, "test", "test", "test", "test", "test", x, "Jan"));
                starrs.Add(new Starr(starrId++, "Teamwork 2", DateTime.Now, "test1", "test1", "test1", "test1", "test1", x2, "Berta"));
                starrs.Add(new Starr(starrId++, "Communication", DateTime.Now, "test2", "test2", "test2", "test2", "test2", x3, "Peter"));
                starrs.Add(new Starr(starrId++, "Writing", DateTime.Now, "test3", "test3", "test3", "test3", "test3", x2, "Wilma"));
                starrs.Add(new Starr(starrId++, "Teamwork 3", DateTime.Now, "test4", "test4", "test4", "test4", "test4", x, "Henk"));
                starrs.Add(new Starr(starrId++, "Communication 2", DateTime.Now, "test5", "test5", "test5", "test5", "test5", x, "Frida"));
                starrs.Add(new Starr(starrId++, "Writing 2", DateTime.Now, "test6", "test6", "test6", "test6", "test6", x2, "Bart"));
                starrs.Add(new Starr(starrId++, "Presentation", DateTime.Now, "test7", "test7", "test7", "test7", "test7", x, "Martha"));
                starrs.Add(new Starr(starrId++, "Writing 3", DateTime.Now, "test8", "test8", "test8", "test8", "test8", x3, "Wim"));
                starrs.Add(new Starr(starrId++, "Presentation 2", DateTime.Now, "test9", "test9", "test9", "test9", "test9", x3, "Anne"));
            }
              
        }

        public List<Starr> GetAllStarrs()
        {
            return starrs;
        }

        public Starr GetStarrById(int id)
        {
            foreach(Starr s in starrs)
            {
                if (s.Id == id)
                {
                    return s;
                }
            }

            return null;
        }

        public void UpdateStarr(Starr sf)
        {
            Starr toUpdate = GetStarrById(sf.Id);
            if (toUpdate != null)
            {
                toUpdate.CopyFrom(sf);
            }

        }

        public void addStarr(Starr s)
        {
            /*foreach (Starr st in starrs)
            {
                if (st.Id == s.Id)
                {
                    s.Id =+ 1;
                }
            }*/
            starrs.Add(s);
        }
    }
}
