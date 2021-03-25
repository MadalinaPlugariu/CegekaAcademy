using Persistance.Data;
using Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persistance.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly WorkLoadDbContext _context;
        private double tempPrice;

        public CustomerRepository(WorkLoadDbContext context)
        {
            _context = context;
        }


        public List<Customer> GetCustomers()
        {
            return _context.Customer.ToList();
        }

        public void AddCustomer(string customerInfo)
        {
            var customer = new Customer() { CustomerInfo = customerInfo };
            _context.Customer.Add(customer);
            _context.SaveChanges();
        }

        public double TotalAmountOfMoney(int idCustomer, int month, int year)
        {

            var workHours = (from c in _context.Customer
                             join p in _context.Project on c.Id equals p.CustomerId
                             join w in _context.Workday on p.Id equals w.IdProject
                             where c.Id == idCustomer && w.Workdays.Year == year && w.Workdays.Month == month
                             select new { w.Hours }).ToList();
            var priceHour = (from c in _context.Customer
                             join p in _context.Project on c.Id equals p.CustomerId
                             join w in _context.Workday on p.Id equals w.IdProject
                             join f in _context.Freelancer on w.IdFreelancer equals f.Id
                             where c.Id == idCustomer && w.Workdays.Year == year && w.Workdays.Month == month
                             select new { f.Price }).ToList();

            var sum = workHours.Select(s => s.Hours).Sum();


            foreach (var price in priceHour)
            {
                double tempPrice = price.Price;
            }


            var totalAmountOfMoney = sum * tempPrice;
            return totalAmountOfMoney;

        }

    }
}
