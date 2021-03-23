using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLoad.Entities;

namespace WorkLoad.Repositories
{
    public interface IFreelancerRepository
    {
        public List<Freelancer> GetFreelancers();
        public void AddFreelancer(Freelancer freelancer);
    }
}
