using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistance.Entities
{
    public class Freelancer
    {
        public int Id { get; set; }
        public string FreelancerInfo { get; set; } //fname, lname
        public double Price { get; set; }
        public AddressFreelancer AddressFreelancer { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Workday> Workdays { get; set; }

        //new table adress 
        public Freelancer()
        {
            Projects = new HashSet<Project>();
            Workdays = new HashSet<Workday>();
        }
        public Freelancer(string freelancerInfo, double price)
        {

            FreelancerInfo = freelancerInfo;
            Price = price;
        }
    }
}
