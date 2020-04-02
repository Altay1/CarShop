using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Shop.Models.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddProduct(Product product)
        {
            _appDbContext.Products.Add(product);
        }

        public Product GetProduct(int id)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _appDbContext.Products.ToList();
        }

        public bool RemoveProduct(int id)
        {
            bool succes = false;
            var product = _appDbContext.Products.FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                _appDbContext.Remove(product);
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
