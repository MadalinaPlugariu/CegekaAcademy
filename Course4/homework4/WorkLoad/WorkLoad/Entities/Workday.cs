using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkLoad.Entities
{
    public class Workday
    {
        //project object
        public int Id { get; set; }
        public DateTime Workdays { get; set; }
        public double Hours { get; set; }
        public Nullable<int> WorkdayType { get; set; }
        public int? IdProject { get; set; }
        public virtual Project Project { get; set; }
        public Workday(DateTime workdays, double hours)
        {
            Workdays = workdays;
            Hours = hours;
        }

    }
}
