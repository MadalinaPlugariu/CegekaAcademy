using Persistance.Data;
using Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persistance.Repositories
{
    public class FreelancerRepository : IFreelancerRepository
    {
        private readonly WorkLoadDbContext _context;
        public FreelancerRepository(WorkLoadDbContext context)
        {
            _context = context;
        }


        public List<Freelancer> GetFreelancers()
        {
            return _context.Freelancer.ToList();
        }
        public void AddFreelancer(string freelancerInfo, double price)
        {
            var freelancer = new Freelancer() { FreelancerInfo = freelancerInfo, Price = price };
            _context.Freelancer.Add(freelancer);
            _context.SaveChanges();
        }
        public void AddWorkload(int freelancerId, DateTime dateTime, double hours)
        {
            if (hours <= 8)
            {
                Workday workday = new Workday()
                {
                    Hours = hours,
                    Workdays = dateTime,
                    IdFreelancer = freelancerId
                };
                _context.Workday.Add(workday);
                _context.SaveChanges();

            }
            else
            {
                Console.WriteLine("Give a smaller number for hours.");
            }
        }
    }
}
