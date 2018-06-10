using System.Collections.Generic;
using Models;

namespace DAL
{
    public interface IStarrContext
    {
        List<Starr> GetAllStarrsForUser(int userId);
        List<Starr> GetAllStarrsForCoach(int coachId);
        Starr GetStarrById(int id);
        void UpdateStarr(Starr starr);
        void AddStarr(Starr starr);
        List<string> GetAllSoftSkills();
    }
}