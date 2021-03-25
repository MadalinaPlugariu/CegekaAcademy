using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistance.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerInfo { get; set; }

        public virtual AddressProject AddressProject { get; set; }
        public ICollection<Project> Project { get; set; }
    }
}
