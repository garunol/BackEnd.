using LAB4.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB4.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details()
        {
            var product = new Product
            {
                Id = 1,
                Name = "Laptop Dell XPS",
                Price = 29999.99m
            };



            return View(product);
            
        }
    }
}
