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
                var x = Emotions.VeryPositive;
                var x2 = Emotions.Positive;
                var x3 = Emotions.Negative;
                var x4 = Emotions.VeryNegative;

                starrs.Add(new Starr(1, "Teamwork", DateTime.Now, "test", "test", "test", "test", "test", x, "Jan"));
                starrs.Add(new Starr(2, "Teamwork 2", DateTime.Now, "test1", "test1", "test1", "test1", "test1", x2, "Berta"));
                starrs.Add(new Starr(3, "Communication", DateTime.Now, "test2", "test2", "test2", "test2", "test2", x3, "Peter"));
                starrs.Add(new Starr(4, "Writing", DateTime.Now, "test3", "test3", "test3", "test3", "test3", x2, "Wilma"));
                starrs.Add(new Starr(5, "Teamwork 3", DateTime.Now, "test4", "test4", "test4", "test4", "test4", x, "Henk"));
                starrs.Add(new Starr(6, "Communication 2", DateTime.Now, "test5", "test5", "test5", "test5", "test5", x4, "Frida"));
                starrs.Add(new Starr(7, "Writing 2", DateTime.Now, "test6", "test6", "test6", "test6", "test6", x2, "Bart"));
                starrs.Add(new Starr(8, "Presentation", DateTime.Now, "test7", "test7", "test7", "test7", "test7", x, "Martha"));
                starrs.Add(new Starr(9, "Writing 3", DateTime.Now, "test8", "test8", "test8", "test8", "test8", x3, "Wim"));
                starrs.Add(new Starr(10, "Presentation 2", DateTime.Now, "test9", "test9", "test9", "test9", "test9", x4, "Anne"));
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
    }
}
