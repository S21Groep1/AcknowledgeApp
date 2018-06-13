using System;
using System.Collections.Generic;
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
                isInitialized = true;
            }
        }

        public void AddStarr(Starr starr)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllSoftSkills()
        {
            throw new NotImplementedException();
        }

        public List<Starr> GetAllStarrsForCoach(int coachId)
        {
            throw new NotImplementedException();
        }

        public List<Starr> GetAllStarrsForUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Starr GetStarrById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateStarr(Starr starr)
        {
            throw new NotImplementedException();
        }
    }
}