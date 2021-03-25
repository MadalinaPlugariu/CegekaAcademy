using Microsoft.AspNetCore.Mvc;
using Persistance.Entities;
using Persistance.Repositories;
using System;

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
        public IActionResult DisplayFreelancers()
        {
           var freelancers = _freelancerRepository.GetFreelancers();
            return Ok(freelancers);
        }

        [HttpPost("addFreelancer")]
        public IActionResult AddFreelancer(string freelancerInfo, double price)
        {
            _freelancerRepository.AddFreelancer(freelancerInfo, price);
            return Ok();
        }

        [HttpPost("addWorkload")]
        public IActionResult AddWorkload(int freelancerId, DateTime dateTime, double hours)
        {
            _freelancerRepository.AddWorkload(freelancerId, dateTime, hours);
            return Ok();
        }

    }
}
