using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car_Shop.Models.Repositories;
using Car_Shop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Car_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepo _productRepo;
        public HomeController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var products = new ProductsViewModel()
            {
                Products = _productRepo.GetProducts()
            };

            return View(products);
        }
    }
}
