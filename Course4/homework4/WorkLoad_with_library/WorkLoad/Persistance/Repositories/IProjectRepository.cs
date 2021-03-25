using Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public interface IProjectRepository
    {
        public List<Project> GetProjects();
        public void AddProject(string projectInfo, int estimationDays);
        public bool CheckLoad(int idProject);
    }
}
