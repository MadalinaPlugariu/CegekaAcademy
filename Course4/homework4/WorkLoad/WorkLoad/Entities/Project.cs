using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkLoad.Entities
{
    public class Project
    {
        public int Id{ get; set; }
        public string ProjectInfo { get; set; }
        public double EstimationDays { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public virtual ICollection<Freelancer> Freelancers { get; set; }
        public virtual ICollection<Workday> Workdays { get; set; }

        public Project()
        {
            this.Freelancers = new HashSet<Freelancer>();
            this.Workdays = new HashSet<Workday>();
        }
        public Project(string projectInfo, double estimationDays, string customer, string address, string zipcode, string city, string state, string county){
            ProjectInfo = projectInfo;
            EstimationDays = estimationDays;
            Customer = customer;
            Address = address;
            Zipcode = zipcode;
            City = city;
            State = state;
            County = county;
        }
    }
}
