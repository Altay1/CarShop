using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Shop.Models.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext _appDbContext;
        public CustomerRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddCustomer(Customer customer)
        {
            _appDbContext.Customers.Add(customer);
        }

        public Customer GetCustomer(int id)
        {
            return _appDbContext.Customers.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _appDbContext.Customers.ToList();
        }

        public bool RemoveCustomer(int id)
        {
            bool succes = false;
            var customer = _appDbContext.Customers.FirstOrDefault(p => p.Id == id);
            if (customer != null)
            {
                _appDbContext.Customers.Remove(customer);
                return succes = true;
            }
            else
                return succes;
        }
        public void Save()
        {
            _appDbContext.SaveChanges();
        }
    }
}
