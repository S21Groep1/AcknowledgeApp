using System.Collections.Generic;
using Models;
using DAL;

namespace Repository
{
    public class StarrRepository
    {
        private readonly IStarrContext context;

        public StarrRepository()
        {
            context = new StarrContext();
        }

        public List<Starr> GetAllStarrsForUser(int userId) => context.GetAllStarrsForUser(userId);
        public List<Starr> GetAllStarrsForCoach(int coachId) => context.GetAllStarrsForCoach(coachId);
        public Starr GetStarrById(int id) => context.GetStarrById(id);
        public void UpdateStarr(Starr starr) => context.UpdateStarr(starr);
        public void AddStarr(Starr starr) => context.AddStarr(starr);
        public List<string> GetAllSoftSkills() => context.GetAllSoftSkills();
        
    }
}