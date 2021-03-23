using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLoad.Entities;

namespace WorkLoad.Repositories
{
    public interface IProjectRepository
    {
        public List<Project> GetProjects();
        public void AddProject(Project project);
    }
}
