using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Shop.Models.Repositories
{
    public interface IProductRepo
    {
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts();
        void AddProduct(Product product);
        bool RemoveProduct(int id);
        void Save();
    }
}
