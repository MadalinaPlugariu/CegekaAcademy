using Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistance.Repositories

{
    public interface IFreelancerRepository
    {
        public List<Freelancer> GetFreelancers();
        public void AddFreelancer(string freelancerInfo, double price);
        public void AddWorkload(int freelancerId, DateTime dateTime, double hours);
    }
}
