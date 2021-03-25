using Microsoft.AspNetCore.Mvc;
using Persistance.Entities;
using Persistance.Repositories;
using System;

namespace WorkLoad.Controllers
{
    public class WorkdayController: ControllerBase
    {
        private IWorkdayRepository _workdayRepository { get; set; }
        public WorkdayController(IWorkdayRepository workdayRepository)
        {
            _workdayRepository = workdayRepository;
        }

        [HttpGet("displayWorkdays")]
        public IActionResult DisplayWorkdays()
        {
            var workday = _workdayRepository.GetWorkdays();
            return Ok(workday);
        }

        [HttpPost("addWorkday")]
        public IActionResult AddWorkday(DateTime date, double hours)
        {
            _workdayRepository.AddWorkday(date, hours);
            return Ok();
        }
    }
}
