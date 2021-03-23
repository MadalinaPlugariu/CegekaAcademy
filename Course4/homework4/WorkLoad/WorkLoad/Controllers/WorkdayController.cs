using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLoad.Entities;
using WorkLoad.Repositories;

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
        public async Task<IActionResult> DisplayWorkdays()
        {
            var workday = _workdayRepository.GetWorkdays();
            return Ok(workday);
        }

        [HttpPost("addWorkday")]
        public async Task<IActionResult> AddWorkday(Workday workday)
        {
            _workdayRepository.AddWorkday(workday);
            return Ok();
        }
    }
}
