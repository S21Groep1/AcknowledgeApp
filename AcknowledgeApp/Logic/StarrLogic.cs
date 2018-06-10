using System;
using System.Collections.Generic;
using Models;
using Repository;

namespace Logic
{
    public class StarrLogic
    {
        private StarrRepository starrRepo;
        private UserRepository userRepo;

        public StarrLogic()
        {
            starrRepo = new StarrRepository();
            userRepo = new UserRepository();
        }

        public List<Starr> GetAllStarsForUser(int userId) => starrRepo.GetAllStarrsForUser(userId);
        public List<Starr> GetAllStarrsForCoach(int coachId) => starrRepo.GetAllStarrsForCoach(coachId);
        public Starr GetStarrById(int id)
        {
            Starr starr = starrRepo.GetStarrById(id);
            if(starr == null)
            {
                throw new Exception("Something went wrong finding the starr Id");
            }

            return starr;
        }
        public void UpdateStarr(Starr starr)
        {
            Starr starrToUpdate = GetStarrById(starr.Id);

            if (starr == null || starrToUpdate == null)
            {
                throw new Exception("Something went wrong there!");
            }

            starrToUpdate.CopyFrom(starr);
            starrToUpdate.LastEdit = DateTime.Now;
            starrRepo.UpdateStarr(starrToUpdate);
        }
        public void AddStarr(Starr starr) => starrRepo.AddStarr(starr);
        public List<string> GetAllSoftSkills() => starrRepo.GetAllSoftSkills();
    }
}