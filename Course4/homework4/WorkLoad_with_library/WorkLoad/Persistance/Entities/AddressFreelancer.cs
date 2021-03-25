using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistance.Entities
{
    public class AddressFreelancer
    {
        public int Id { get; set; }
        public string AddressLocation { get; set; }
        public float Zipcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }

        public int FreelancerId { get; set; }
        public Freelancer Freelancer { get; set; }
    }
}
