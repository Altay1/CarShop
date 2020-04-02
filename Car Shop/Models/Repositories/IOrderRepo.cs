using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Shop.Models.Repositories
{
    public interface IOrderRepo
    {
        Order GetOrder(int id);
        IEnumerable<Order> GetOrders();
        void AddOrder(Order order);
        bool RemoveOrder(int id);
        void Save();
    }
}
