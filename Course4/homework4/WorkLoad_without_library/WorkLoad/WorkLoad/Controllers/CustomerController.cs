using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLoad.Entities;
using WorkLoad.Repositories;

namespace WorkLoad.Controllers
{
    [System.Web.Http.Route("api/[controller]")]
    [ApiController]
    public class CustomerController :  ControllerBase
    {
        private ICustomerRepository _customerRepository { get; set; }
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        [HttpGet("displayCustomers")]
        public IActionResult DisplayCustomers()
        {
            var customer = _customerRepository.GetCustomers();
            return Ok(customer);
        }

        [HttpGet("displayTotalAmountOfMoney")]
        public IActionResult TotalAmountOfMoney(int idCustomer, int month, int year)
        {
            var total = _customerRepository.TotalAmountOfMoney(idCustomer, month, year);
            return Ok(total);
        }

        [HttpPost("addCustomer")]
        public IActionResult AddCustomer(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
            return Ok();
        }



    }
}
