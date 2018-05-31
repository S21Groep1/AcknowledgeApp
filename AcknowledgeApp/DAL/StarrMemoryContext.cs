using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace DAL
{
    public class StarrMemoryContext : IStarrContext
    {
        private static List<Starr> starrs = new List<Starr>();
        private static bool isInitialized = false;
        public StarrMemoryContext()
        {
            if (!isInitialized)
            {
                var x = Emotions.Positive;
                var x2 = Emotions.Negative;
                var x3 = Emotions.Neutral;
                Create(new Starr() { Id = 0, Name = "Teamwork", LastEdit = DateTime.Now, StartDate = DateTime.Now, Situation = "test", Task = "test", Action = "test", Result = "test", Reflection = "test", Feeling = x, Coach = "Jan"});
                Create(new Starr() { Name = "Teamwork 2", LastEdit = DateTime.Now, StartDate = DateTime.Now, Situation = "test1", Task = "test1", Action = "test1", Result = "test1", Reflection = "test1", Feeling = x2, Coach = "Berta" });
                Create(new Starr() { Name = "Communication", LastEdit = DateTime.Now, StartDate = DateTime.Now, Situation = "test2", Task = "test2", Action = "test2", Result = "test2", Reflection = "test2", Feeling = x2, Coach = "Peter" });
                Create(new Starr() { Name = "Writing", LastEdit = DateTime.Now, StartDate = DateTime.Now, Situation = "test3", Task = "test3", Action = "test3", Result = "test3", Reflection = "test3", Feeling = x3, Coach = "Wilma" });
                Create(new Starr() { Name = "Teamwork 3", LastEdit = DateTime.Now, StartDate = DateTime.Now, Situation = "test4", Task = "test4", Action = "test4", Result = "test4", Reflection = "test4", Feeling = x2, Coach = "Henk" });
                Create(new Starr() { Name = "Communication 2", LastEdit = DateTime.Now, StartDate = DateTime.Now, Situation = "test5", Task = "test5", Action = "test5", Result = "test5", Reflection = "test5", Feeling = x2, Coach = "Frida" });
                Create(new Starr() { Name = "Writing 2", LastEdit = DateTime.Now, StartDate = DateTime.Now, Situation = "test6", Task = "test6", Action = "test6", Result = "test6", Reflection = "test6", Feeling = x, Coach = "Bart" });
                Create(new Starr() { Name = "Presentation", LastEdit = DateTime.Now, StartDate = DateTime.Now, Situation = "test7", Task = "test7", Action = "test7", Result = "test7", Reflection = "test7", Feeling = x3, Coach = "Martha" });
                Create(new Starr() { Name = "Writing 3", LastEdit = DateTime.Now, StartDate = DateTime.Now, Situation = "test8", Task = "test8", Action = "test8", Result = "test8", Reflection = "test8", Feeling = x2, Coach = "Wim" });

                isInitialized = true;
            }
              
        }
        public void Create(Starr starr)
        {
            starrs.Add(starr);
            starr.Id = GetNextId();
        }

        public IEnumerable<Starr> GetAll() => starrs;

        public Starr Get(int id) => starrs.Single(i => i.Id == id);

        public void UpdateStarr(Starr sf)
        {
            Starr toUpdate = Get(sf.Id);
            if (toUpdate != null)
            {
                toUpdate.CopyFrom(sf);
            }
        }
        private int GetNextId() => starrs.Max(i => i.Id) + 1;

    }
}
