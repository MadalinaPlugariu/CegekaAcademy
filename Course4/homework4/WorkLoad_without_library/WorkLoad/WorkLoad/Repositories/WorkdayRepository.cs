using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLoad.Data;
using WorkLoad.Entities;

namespace WorkLoad.Repositories
{
   
    public class WorkdayRepository:IWorkdayRepository
    {
        private readonly WorkLoadDbContext _context;

        public WorkdayRepository(WorkLoadDbContext context)
        {
            _context = context;
        }

        public List<Workday> GetWorkdays()
        {
            return _context.Workday.ToList();
        }

        public void AddWorkday(Workday workday)
        {
            _context.Workday.Add(workday);
            _context.SaveChanges();
        }
    }
}
