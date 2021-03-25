using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLoad.Entities;

namespace WorkLoad.Repositories
{
    public interface ICustomerRepository
    {
        public List<Customer> GetCustomers();
        public void AddCustomer(Customer customer);
        public double TotalAmountOfMoney(int idCustomer, int month, int year);

    }
}
