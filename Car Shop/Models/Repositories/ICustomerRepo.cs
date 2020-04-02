using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Shop.Models.Repositories
{
    public interface ICustomerRepo
    {
        Customer GetCustomer(int id);
        IEnumerable<Customer> GetCustomers();
        void AddCustomer(Customer customer);
        bool RemoveCustomer(int id);

        void Save();

    }
}
