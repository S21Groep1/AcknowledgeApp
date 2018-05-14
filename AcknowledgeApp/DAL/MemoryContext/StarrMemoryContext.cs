using System;
using System.Collections.Generic;
using Models;

namespace DAL
{
    public class StarrMemoryContext : IStarrContext
    {
        private static List<Starr> starrs = new List<Starr>();

        public StarrMemoryContext()
        {
            if (starrs.Count == 0)
            {
                var x = Emotions.Positive;
                var x2 = Emotions.Negative;
                var x3 = Emotions.Neutral;

                starrs.Add(new Starr(1, "Teamwork", DateTime.Now, "test", "test", "test", "test", "test", x, "Jan"));
                starrs.Add(new Starr(2, "Teamwork 2", DateTime.Now, "test1", "test1", "test1", "test1", "test1", x2, "Berta"));
                starrs.Add(new Starr(3, "Communication", DateTime.Now, "test2", "test2", "test2", "test2", "test2", x3, "Peter"));
                starrs.Add(new Starr(4, "Writing", DateTime.Now, "test3", "test3", "test3", "test3", "test3", x2, "Wilma"));
                starrs.Add(new Starr(5, "Teamwork 3", DateTime.Now, "test4", "test4", "test4", "test4", "test4", x, "Henk"));
                starrs.Add(new Starr(6, "Communication 2", DateTime.Now, "test5", "test5", "test5", "test5", "test5", x, "Frida"));
                starrs.Add(new Starr(7, "Writing 2", DateTime.Now, "test6", "test6", "test6", "test6", "test6", x2, "Bart"));
                starrs.Add(new Starr(8, "Presentation", DateTime.Now, "test7", "test7", "test7", "test7", "test7", x, "Martha"));
                starrs.Add(new Starr(9, "Writing 3", DateTime.Now, "test8", "test8", "test8", "test8", "test8", x3, "Wim"));
                starrs.Add(new Starr(10, "Presentation 2", DateTime.Now, "test9", "test9", "test9", "test9", "test9", x3, "Anne"));
            }
        }

        public IEnumerable<Starr> GetAllStarrs() => starrs;

        public Starr GetStarrById(int id)
        {
            Starr foundStarr = starrs.Find(s => s.Id == id);
            if (foundStarr != null)
            {
                return foundStarr;
            } else
            {
                throw new Exception("There is no starr with that ID!");
            }
        }

        public void UpdateStarr(Starr starr)
        {
            Starr toUpdate = GetStarrById(starr.Id);
            if (toUpdate != null)
            {
                toUpdate.CopyFrom(starr);
            }
        }
    }
}