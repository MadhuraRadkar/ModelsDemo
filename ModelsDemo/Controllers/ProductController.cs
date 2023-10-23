using Microsoft.AspNetCore.Mvc;
using ModelsDemo.Models;
namespace ModelsDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1,Name="Mouse",Price=299},
                new Product { Id = 2,Name="Pen",Price=20},
                new Product { Id = 3,Name="Pencil",Price=15},
                new Product { Id = 4,Name="Pendrive",Price=799},
                new Product { Id = 5,Name="Notebook",Price=150},
                 
            };

            ViewBag.List = products;
            return View();
        }
    }
}
