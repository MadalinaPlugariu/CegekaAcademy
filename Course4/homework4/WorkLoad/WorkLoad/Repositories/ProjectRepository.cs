using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLoad.Data;
using WorkLoad.Entities;

namespace WorkLoad.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly WorkLoadDbContext _context;
        public ProjectRepository(WorkLoadDbContext context)
        {
            _context = context;
        }


        public List<Project> GetProjects()
        {
            return _context.Project.ToList();
        }

        public void AddProject(Project project)
        {
            _context.Project.Add(project);
            _context.SaveChanges();
        }

    }
}
