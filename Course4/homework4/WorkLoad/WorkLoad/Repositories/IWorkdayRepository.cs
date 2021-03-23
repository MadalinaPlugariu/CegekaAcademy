using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLoad.Entities;

namespace WorkLoad.Repositories
{
    public interface IWorkdayRepository
    {
        public List<Workday> GetWorkdays();
        public void AddWorkday(Workday workday);
        public void AddWorload(Workday workday);
    }
}
