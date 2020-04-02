using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Shop.Models.Repositories
{
    public class OrderRepo : IOrderRepo
    {
        private readonly AppDbContext _appDbContext;
        public OrderRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddOrder(Order order)
        {
            _appDbContext.Orders.Add(order);
        }

        public Order GetOrder(int id)
        {
            return _appDbContext.Orders.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Order> GetOrders()
        {
            return _appDbContext.Orders.ToList();
        }

        public bool RemoveOrder(int id)
        {
            bool succes = false;

            var order = _appDbContext.Orders.FirstOrDefault(p => p.Id == id);
            if (order != null)
            {
                _appDbContext.Remove(order);
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
