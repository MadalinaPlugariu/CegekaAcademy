using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistance.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectInfo { get; set; }
        public int EstimationDays { get; set; }
        public AddressProject AddressProject { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public virtual ICollection<Freelancer> Freelancers { get; set; }
        public virtual ICollection<Workday> Workdays { get; set; }

        //customer 
        public Project()
        {
            Freelancers = new HashSet<Freelancer>();
            Workdays = new HashSet<Workday>();
        }
        public Project(string projectInfo, int estimationDays)
        {
            ProjectInfo = projectInfo;
            EstimationDays = estimationDays;
        }
    }
}
