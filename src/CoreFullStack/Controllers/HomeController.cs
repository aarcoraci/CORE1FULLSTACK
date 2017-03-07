using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreFullStack.DataAccess.Repositories;
using CoreFullStack.Domain;

namespace CoreFullStack.Controllers
{
    public class HomeController : Controller
    {
        public ICategoryRepository CategoryRepository { get; set; }
        public IProductRepository ProductRepository { get; set; }

        public HomeController(ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            CategoryRepository = categoryRepository;
            ProductRepository = productRepository;
        }

        public IActionResult Index()
        {
            Product p = new Product()
            {
                Id = Guid.NewGuid(),
                Name = "test"
            };
            ProductRepository.Insert(p);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
