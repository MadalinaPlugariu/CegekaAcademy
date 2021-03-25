using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLoad.Data;
using WorkLoad.Entities;

namespace WorkLoad.Repositories
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
        public void AddFreelancer(Freelancer freelancer)
        {
            _context.Freelancer.Add(freelancer);
            _context.SaveChanges();
        }
        public void AddWorkload (int freelancerId, DateTime dateTime, double hours)
        {
            if (hours <= 8) {
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
