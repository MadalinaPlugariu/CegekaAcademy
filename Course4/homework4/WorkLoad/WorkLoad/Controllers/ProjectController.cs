/*using Microsoft.AspNetCore.Components;*/
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLoad.Entities;
using WorkLoad.Repositories;

namespace WorkLoad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IProjectRepository _projectRepository { get; set; }
        public ProjectController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        [HttpGet("displayProjects")]
        public async Task<IActionResult> DisplayProjects()
        {
            var projects = _projectRepository.GetProjects();
            return Ok(projects);
        }

        [HttpPost("addProject")]
        public async Task<IActionResult> AddProject(Project project)
        {
            _projectRepository.AddProject(project);
            return Ok();
        }
    }
    
}
