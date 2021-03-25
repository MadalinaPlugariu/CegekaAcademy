using Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public interface IWorkdayRepository
    {
        public List<Workday> GetWorkdays();
        public void AddWorkday(DateTime date, double hours);
    }
}
