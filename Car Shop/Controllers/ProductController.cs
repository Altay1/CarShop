using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car_Shop.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Car_Shop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo _productRepo;
        public ProductController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
