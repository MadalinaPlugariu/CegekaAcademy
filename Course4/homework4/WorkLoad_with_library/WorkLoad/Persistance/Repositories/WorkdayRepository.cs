using Persistance.Data;
using Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistance.Repositories
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

        public void AddWorkday(DateTime date, double hours)
        {
            var workday = new Workday() { Workdays = date, Hours = hours };
            _context.Workday.Add(workday);
            _context.SaveChanges();
        }
    }
}
