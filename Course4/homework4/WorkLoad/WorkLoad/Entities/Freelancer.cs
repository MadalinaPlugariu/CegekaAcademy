using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkLoad.Entities
{
    public class Freelancer
    {
        public int Id{ get; set; }
        public string FreelancerInfo { get; set; }
        public double Price { get; set; }
        public string Address { get; set; }
        public float Zipcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Workday> Workdays { get; set; }

        public Freelancer()
        {
            this.Projects = new HashSet<Project>();
            this.Workdays = new HashSet<Workday>();
        }
        public Freelancer(string freelancerInfo, double price, string address, float zipcode, string city, string state, string county)
        {

            FreelancerInfo = freelancerInfo;
            Price = price;
            Address = address;
            Zipcode = zipcode;
            City = city;
            State = state;
            County = county;
        }
    }
}
