using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Shop.Models.Repositories
{
    public interface IOrderDetailRepo
    {
        OrderDetail GetOrderDetail(int id);
        IEnumerable<OrderDetail> GetOrderDetails();
        void AddOrderDetail(OrderDetail orderDetail);
        bool RemoveOrderDetail(int id);
        void Save();
    }
}
