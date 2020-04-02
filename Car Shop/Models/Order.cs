using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Shop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string NameOnCard { get; set; }
        public string Adress { get; set; }
        public string PhoneNum { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
