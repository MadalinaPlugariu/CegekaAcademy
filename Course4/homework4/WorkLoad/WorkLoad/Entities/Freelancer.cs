using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkLoad.Entities
{
    public class Freelancer
    {
        public int Id{ get; set; }
        public string FreelancerInfo { get; set; } //fname, lname
        public double Price { get; set; }
        public  AddressFreelancer AddressFreelancer { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Workday> Workdays { get; set; }

        //new table adress 
        public Freelancer()
        {
            this.Projects = new HashSet<Project>();
            this.Workdays = new HashSet<Workday>();
        }
        public Freelancer(string freelancerInfo, double price)
        {

            FreelancerInfo = freelancerInfo;
            Price = price;
        }
    }
}
