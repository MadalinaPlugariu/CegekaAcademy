using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistance.Entities;
using Persistance.Repositories;

namespace WorkLoad.Controllers
{
    [System.Web.Http.Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IProjectRepository _projectRepository { get; set; }
        public ProjectController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        [HttpGet("displayProjects")]
        public IActionResult DisplayProjects()
        {
            var projects = _projectRepository.GetProjects();
            return Ok(projects);
        }

        [HttpGet("checkLoad")]
        public IActionResult CheckLoad(int idProject)
        {
            var check = _projectRepository.CheckLoad(idProject);
            if (check == true)
                return Ok();
            else
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        [HttpPost("addProject")]
        public IActionResult AddProject(string projectInfo, int estimationDays)
        {
            _projectRepository.AddProject(projectInfo, estimationDays);
            return Ok();
        }
    }
    
}