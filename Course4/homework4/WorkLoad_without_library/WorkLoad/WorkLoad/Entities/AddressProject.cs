using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkLoad.Entities
{
    public class AddressProject
    {

        public int Id { get; set; }
        public string AddressLocation { get; set; }
        public float Zipcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }

        public int ProjectId { get; set; }
        public int CustomerId { get; set; }
        public Project Project { get; set; }
        public Customer Customer { get; set; }
    }
}
