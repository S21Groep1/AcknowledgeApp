using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL
{
    class StarrContext : IStarrContext
    {
        private List<Starrform> starrs = new List<Starrform>();

        public StarrContext()
        {
            var x = Emotions.Positive;
            var x2 = Emotions.Negative;
            var x3 = Emotions.Neutral;

            starrs.Add(new Starrform(1, "Teamwork", DateTime.Now, "test", "test", "test", "test", "test", x, "Jan"));
            starrs.Add(new Starrform(2, "Teamwork 2", DateTime.Now, "test1", "test1", "test1", "test1", "test1", x2, "Berta"));
            starrs.Add(new Starrform(3, "Communication", DateTime.Now, "test2", "test2", "test2", "test2", "test2", x3, "Peter"));
            starrs.Add(new Starrform(4, "Writing", DateTime.Now, "test3", "test3", "test3", "test3", "test3", x2, "Wilma"));
            starrs.Add(new Starrform(5, "Teamwork 3", DateTime.Now, "test4", "test4", "test4", "test4", "test4", x, "Henk"));
            starrs.Add(new Starrform(6, "Communication 2", DateTime.Now, "test5", "test5", "test5", "test5", "test5", x, "Frida"));
            starrs.Add(new Starrform(7, "Writing 2", DateTime.Now, "test6", "test6", "test6", "test6", "test6", x2, "Bart"));
            starrs.Add(new Starrform(8, "Presentation", DateTime.Now, "test7", "test7", "test7", "test7", "test7", x, "Martha"));
            starrs.Add(new Starrform(9, "Writing 3", DateTime.Now, "test8", "test8", "test8", "test8", "test8", x3, "Wim"));
            starrs.Add(new Starrform(10, "Presentation 2", DateTime.Now, "test9", "test9", "test9", "test9", "test9", x3, "Anne"));
        }

        public List<Starrform> GetAllStarrs()
        {
            return starrs;
        }

        public Starrform GetStarrById(int id)
        {
            foreach(Starrform s in starrs)
            {
                if (s.Id == id)
                {
                    return s;
                }
            }

            return null;
        }

        public void UpdateStarr(Starrform sf)
        {
            Starrform toUpdate = GetStarrById(sf.Id);
            if (toUpdate != null)
            {
                toUpdate.CopyFrom(sf);
            }

        }
    }
}
