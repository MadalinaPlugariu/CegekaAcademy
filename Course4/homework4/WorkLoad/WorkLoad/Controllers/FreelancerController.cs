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
    public class FreelancerController:ControllerBase
    {
        private IFreelancerRepository _freelancerRepository { get; set; }
        public FreelancerController(IFreelancerRepository freelancerRepository)
        {
            _freelancerRepository = freelancerRepository;
        }


        [HttpGet("displayFreelancers")]
        public async Task<IActionResult> DisplayFreelancers()
        {
           var freelancers = _freelancerRepository.GetFreelancers();
            return Ok(freelancers);
        }

        [HttpPost("addFreelancer")]
        public async Task<IActionResult> AddFreelancer(Freelancer freelancer)
        {
            _freelancerRepository.AddFreelancer(freelancer);
            return Ok();
        }
    }
}
