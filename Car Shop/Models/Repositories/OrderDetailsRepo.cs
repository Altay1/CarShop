using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Shop.Models.Repositories
{
    public class OrderDetailsRepo : IOrderDetailRepo
    {
        private readonly AppDbContext _appDbContext;

        public OrderDetailsRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddOrderDetail(OrderDetail orderDetail)
        {
            _appDbContext.OrderDetails.Add(orderDetail);
        }

        public OrderDetail GetOrderDetail(int id)
        {
            return _appDbContext.OrderDetails.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            return _appDbContext.OrderDetails.ToList();
        }

        public bool RemoveOrderDetail(int id)
        {
            bool succes = false;
            var orderDetail = _appDbContext.OrderDetails.FirstOrDefault(p => p.Id == id);

            if (orderDetail != null)
            {
                _appDbContext.Remove(orderDetail);
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
