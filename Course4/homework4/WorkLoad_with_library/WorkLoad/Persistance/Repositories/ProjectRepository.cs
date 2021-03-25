using Persistance.Data;
using Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly WorkLoadDbContext _context;
        private int day;

        public ProjectRepository(WorkLoadDbContext context)
        {
            _context = context;
        }


        public List<Project> GetProjects()
        {
            return _context.Project.ToList();
        }

        public void AddProject(string projectInfo, int estimationDays)
        {
            var project = new Project() { ProjectInfo = projectInfo, EstimationDays = estimationDays };
            _context.Project.Add(project);
            _context.SaveChanges();
        }

        public bool CheckLoad(int idProject)
        {
            var countWorkdays = (from p in _context.Project
                                 join w in _context.Workday on p.Id equals w.IdProject
                                 where p.Id == idProject
                                 select new { w.Workdays }).Count();

            var estimationDays = from p in _context.Project
                                 where p.Id == idProject
                                 select new { p.EstimationDays };

            foreach (var e in estimationDays)
            {
                day = e.EstimationDays;
            }
            if (countWorkdays < day)
                return false;
            return true;

        }
        

    }
}
