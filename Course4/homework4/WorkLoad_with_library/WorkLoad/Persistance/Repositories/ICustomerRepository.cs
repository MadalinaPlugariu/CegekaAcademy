using Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistance.Repositories

{
    public interface ICustomerRepository
    {
        public List<Customer> GetCustomers();
        public void AddCustomer(string customerInfo);
        public double TotalAmountOfMoney(int idCustomer, int month, int year);

    }
}
